using Matrox.MatroxImagingLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Global;
using System.Windows.Controls;
using System.Windows.Media.Media3D;
using System.Reflection.Emit;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Documents;
//using static Matrox.Imaging.ObjectMil.Gra;

namespace Vision.MIL_Control
{
    public class HookParameters
    {
        public MIL_ID MilDisplay;
        public MIL_ID MilGraphicsList;
        public MIL_ID MilGraphicsContext;
        public MIL_ID MilBinImage;
        public MIL_ID MilBlobContext;
        public MIL_ID MilBlobResult;
        public MIL_INT RegionLabel;
        public MIL_ObjectControl Control;
    }

    public class MIL_ObjectControl
    {
        public MIL_ID milDisplay;
        public MIL_ID milGraphicContext;
        public MIL_ID milGraphicList;

        public RegionType SelectedType;
        private static HookParameters Data;
        private bool Creating;
        //private MIL_INT Creating_Label;

        GCHandle DataStructureHandle; 

        private MIL_GRA_HOOK_FUNCTION_PTR HookHandlerDelegate = new MIL_GRA_HOOK_FUNCTION_PTR(HookHandler_Modified);
        private MIL_GRA_HOOK_FUNCTION_PTR HookHandlerSelectedDelegate = new MIL_GRA_HOOK_FUNCTION_PTR(HookHandler_Selection_Modified);
        private MIL_GRA_HOOK_FUNCTION_PTR HookHandlerStateDelegate = new MIL_GRA_HOOK_FUNCTION_PTR(HookHandler_State_Modified);

        private Dictionary<int,RegionInfo> RegionTypes;


        public MIL_ObjectControl()
        {
            Creating = false;
            Data = new HookParameters() { Control = this };
            DataStructureHandle = GCHandle.Alloc(Data);

            RegionTypes = new Dictionary<int, RegionInfo>();

        }

        public void Draw()
        {

        }

        public void SetTeachingMode(bool Draw)
        {
            if (Draw)
            {
                MIL.MdispControl(milDisplay, MIL.M_GRAPHIC_LIST_INTERACTIVE, MIL.M_ENABLE);
                MIL.MgraHookFunction(milGraphicList, MIL.M_GRAPHIC_MODIFIED, HookHandlerDelegate, GCHandle.ToIntPtr(DataStructureHandle));
                MIL.MgraHookFunction(milGraphicList, MIL.M_GRAPHIC_SELECTION_MODIFIED, HookHandlerSelectedDelegate, GCHandle.ToIntPtr(DataStructureHandle));
                MIL.MgraHookFunction(milGraphicList, MIL.M_INTERACTIVE_GRAPHIC_STATE_MODIFIED, HookHandlerStateDelegate, GCHandle.ToIntPtr(DataStructureHandle));


            }
            else
            {
                MIL.MdispControl(milDisplay, MIL.M_GRAPHIC_LIST_INTERACTIVE, MIL.M_DISABLE);
                MIL.MgraHookFunction(milGraphicList, MIL.M_GRAPHIC_MODIFIED + MIL.M_UNHOOK, HookHandlerDelegate, GCHandle.ToIntPtr(DataStructureHandle));
                MIL.MgraHookFunction(milGraphicList, MIL.M_GRAPHIC_SELECTION_MODIFIED + MIL.M_UNHOOK, HookHandlerSelectedDelegate, GCHandle.ToIntPtr(DataStructureHandle));
                MIL.MgraHookFunction(milGraphicList, MIL.M_INTERACTIVE_GRAPHIC_STATE_MODIFIED + MIL.M_UNHOOK, HookHandlerStateDelegate, GCHandle.ToIntPtr(DataStructureHandle));
            }
        }

        public void Clear_Interactive()
        {
            MIL.MgraClear(MIL.M_DEFAULT, milGraphicList);
            RegionTypes.Clear();
        }

        public void Create_Rect(RegionType type, double x,double y,double width, double height)
        {
            RegionInfo rgn = new RegionInfo()
            {
                index = RegionTypes.Count,
                type = type
            };

            MIL_INT mIL_INT = MIL.M_NULL;
            MIL.MgraRect(milGraphicContext, milGraphicList, x, y, x + width, y + height);
            MIL.MgraInquireList(milGraphicList, MIL.M_LIST, MIL.M_DEFAULT, MIL.M_LAST_LABEL, ref mIL_INT);
            RegionTypes.Add((int)mIL_INT, rgn);
        }

        private static MIL_INT HookHandler_Modified(MIL_INT HookType, MIL_ID EventId, IntPtr UserDataPtr)
        {
            if (!IntPtr.Zero.Equals(UserDataPtr))
            {
                GCHandle hUserData = GCHandle.FromIntPtr(UserDataPtr);
                HookParameters DataStructure = hUserData.Target as HookParameters;
                MIL_ObjectControl control = DataStructure.Control;
                

                MIL_INT MilControlType = 0;
                MIL_INT mil_label = 0;

                MIL.MgraGetHookInfo(EventId, MIL.M_GRAPHIC_CONTROL_TYPE, ref MilControlType);
                MIL.MgraGetHookInfo(EventId, MIL.M_GRAPHIC_LABEL_VALUE, ref mil_label);

                
                if (MilControlType == MIL.M_DELETE)
                {
                    control.RegionTypes.Remove((int)mil_label);                    
                }
            }

            return MIL.M_NULL;
        }


        private static MIL_INT HookHandler_Selection_Modified(MIL_INT HookType, MIL_ID EventId, IntPtr UserDataPtr)
        {
            if (!IntPtr.Zero.Equals(UserDataPtr))
            {
                GCHandle hUserData = GCHandle.FromIntPtr(UserDataPtr);
                HookParameters DataStructure = hUserData.Target as HookParameters;
                MIL_ObjectControl control = DataStructure.Control as MIL_ObjectControl;

                MIL_INT mil_label = 0;

                MIL.MgraGetHookInfo(EventId, MIL.M_GRAPHIC_LABEL_VALUE, ref mil_label);
                RegionInfo Info;
                bool b = control.RegionTypes.TryGetValue((int)mil_label, out Info);

                if (b)
                {
                    Color test = GlobalInstance.Get_Selected_Recipe().Region[Info.type].Color;
                    MIL.MgraControlList(control.milGraphicList, MIL.M_LIST, MIL.M_DEFAULT, MIL.M_SELECTED_COLOR, MIL.M_RGB888(test));
                    MIL.MgraControlList(control.milGraphicList, MIL.M_LIST, MIL.M_DEFAULT, MIL.M_INTERACTIVE_ANNOTATIONS_COLOR, MIL.M_RGB888(test));
                }


            }
            return MIL.M_NULL;
        }

        private static MIL_INT HookHandler_State_Modified(MIL_INT HookType, MIL_ID EventId, IntPtr UserDataPtr)
        {
            if (!IntPtr.Zero.Equals(UserDataPtr))
            {
                GCHandle hUserData = GCHandle.FromIntPtr(UserDataPtr);
                HookParameters DataStructure = hUserData.Target as HookParameters;
                MIL_ObjectControl control = DataStructure.Control;

                MIL_INT MilControlType = 0;
                MIL_INT mil_label = 0;

                MIL.MgraGetHookInfo(EventId, MIL.M_INTERACTIVE_GRAPHIC_STATE, ref MilControlType);
                MIL.MgraGetHookInfo(EventId, MIL.M_GRAPHIC_LABEL_VALUE, ref mil_label);


                LogSystem.Log_Add(string.Format("Label : {0} , Type : {1}", mil_label, MilControlType));

                if(MilControlType == MIL.M_STATE_BEING_CREATED)
                {
                    control.Creating = true;                    
                }

                // MIL.M_STATE_GRAPHIC_HOVERED 그래픽에서 손 놨을때.
                if (MilControlType == MIL.M_STATE_GRAPHIC_HOVERED && control.Creating)
                {
                    control.Creating = false;

                    RegionInfo rgn = new RegionInfo()
                    {
                        index = control.RegionTypes.Count,
                        type = control.SelectedType
                    };                    

                    if (control.SelectedType == RegionType.Area)
                    {
                        int XCount = GlobalInstance.Get_Selected_Recipe().XCount;
                        int YCount = GlobalInstance.Get_Selected_Recipe().YCount;

                        double x = 0;
                        double y = 0;
                        double width = 0;
                        double height = 0;

                        MIL.MgraInquireList(control.milGraphicList, MIL.M_GRAPHIC_LABEL(mil_label), MIL.M_DEFAULT, MIL.M_CORNER_TOP_LEFT_X, ref x);
                        MIL.MgraInquireList(control.milGraphicList, MIL.M_GRAPHIC_LABEL(mil_label), MIL.M_DEFAULT, MIL.M_CORNER_TOP_LEFT_Y, ref y);
                        MIL.MgraInquireList(control.milGraphicList, MIL.M_GRAPHIC_LABEL(mil_label), MIL.M_DEFAULT, MIL.M_RECTANGLE_WIDTH, ref width);
                        MIL.MgraInquireList(control.milGraphicList, MIL.M_GRAPHIC_LABEL(mil_label), MIL.M_DEFAULT, MIL.M_RECTANGLE_HEIGHT, ref height);

                        MIL.MgraControlList(control.milGraphicList, MIL.M_GRAPHIC_LABEL(mil_label), MIL.M_DEFAULT, MIL.M_DELETE, MIL.M_DEFAULT);

                        control.Create_StripRegion(x, y, width, height);
                    }
                    else
                    {
                        control.RegionTypes.Add((int)mil_label, rgn);
                    }

                }
            }
            return MIL.M_NULL;
        }

        public void Create_StripRegion(double x, double y, double width, double height)
        {
            MIL_INT label = 0;

            int XCount = GlobalInstance.Get_Selected_Recipe().XCount;
            int YCount = GlobalInstance.Get_Selected_Recipe().YCount;

            if(width == 0)
            {
                width = XCount;
            }
            if(height == 0)
            {
                height = YCount;
            }


            double szwidth = width / XCount;
            double szheight = height / YCount;

            int lineCount = (XCount * 2 + 2) + (Common.IsEvenNumber(XCount) ? 1 : 2) + (YCount * 2 + 2);
            double[] XPoint = new double[lineCount];
            double[] YPoint = new double[lineCount];

            int YStartNum = 0;

            // 좌측상단 좌표 기준 지그재그 일직선
            for (int i = 0; i < XCount * 2 + 2; i++)
            {
                double ptx = i / 2 * szwidth;
                double pty = Common.IsEvenNumber((i + 1) / 2) == true ? 0 : height;

                XPoint[i] = ptx + x;
                YPoint[i] = pty + y;
            }

            if (Common.IsEvenNumber(XCount))
            {
                XPoint[XCount * 2 + 2] = x;
                YPoint[XCount * 2 + 2] = height + y;

                XPoint[XCount * 2 + 2 + 1] = x;
                YPoint[XCount * 2 + 2 + 1] = y;

                YStartNum = XCount * 2 + 2 + 1;
            }
            else
            {
                XPoint[XCount * 2 + 2] = x;
                YPoint[XCount * 2 + 2] = y;

                YStartNum = XCount * 2 + 2 + 0;
            }

            for (int i = 0; i < YCount * 2 + 2; i++)
            {
                double ptx = Common.IsEvenNumber((i + 1) / 2) == true ? 0 : width;
                double pty = i / 2 * szheight;
                XPoint[i + YStartNum] = ptx + x;
                YPoint[i + YStartNum] = pty + y;
            }

            MIL.MgraLines(milGraphicContext, milGraphicList, lineCount, XPoint, YPoint, MIL.M_NULL, MIL.M_NULL, MIL.M_POLYLINE);
            MIL.MgraInquireList(milGraphicList, MIL.M_LIST, MIL.M_DEFAULT, MIL.M_LAST_LABEL, ref label);

            RegionTypes.Add((int)label, new RegionInfo() {type = RegionType.Area, index = RegionTypes.Count});
        }

        public void Set_Current_RegionType(int Type)
        {
            SelectedType = (RegionType)Type;

            Set_Interactive_Color(GlobalInstance.Get_Selected_Recipe().Region[SelectedType].Color);

            // 영역 생성 모드
            MIL.MgraInteractive(milGraphicContext, milGraphicList, MIL.M_GRAPHIC_TYPE_RECT, MIL.M_DEFAULT, MIL.M_AXIS_ALIGNED_RECT);
            
        }

        public void Set_Interactive_Color(Color color)
        {
            MIL.MgraColor(milGraphicContext, MIL.M_RGB888(color));
            MIL.MgraControlList(milGraphicList, MIL.M_LIST, MIL.M_DEFAULT, MIL.M_SELECTED_COLOR, MIL.M_RGB888(color));
            MIL.MgraControlList(milGraphicList, MIL.M_LIST, MIL.M_DEFAULT, MIL.M_INTERACTIVE_ANNOTATIONS_COLOR, MIL.M_RGB888(color));
        }

        public RegionInfo[] Apply_Current_Interactive_to_Region()
        {
            if (RegionTypes.Count > 0)
            {
                RegionInfo[] info = new RegionInfo[RegionTypes.Count];

                int i = 0;
                foreach (var Types in RegionTypes)
                {
                    double RTX = 0;
                    double RTY = 0;
                    double Width = 0;
                    double Height = 0;
                    double RBX = 0;
                    double RBY = 0;

                    MIL.MgraInquireList(milGraphicList, MIL.M_GRAPHIC_LABEL(Types.Key), MIL.M_DEFAULT, MIL.M_CORNER_TOP_LEFT_X, ref RTX);
                    MIL.MgraInquireList(milGraphicList, MIL.M_GRAPHIC_LABEL(Types.Key), MIL.M_DEFAULT, MIL.M_CORNER_TOP_LEFT_Y, ref RTY);
                    MIL.MgraInquireList(milGraphicList, MIL.M_GRAPHIC_LABEL(Types.Key), MIL.M_DEFAULT, MIL.M_CORNER_BOTTOM_RIGHT_X, ref RBX);
                    MIL.MgraInquireList(milGraphicList, MIL.M_GRAPHIC_LABEL(Types.Key), MIL.M_DEFAULT, MIL.M_CORNER_BOTTOM_RIGHT_Y, ref RBY);

                    Width = Math.Abs(RBX - RTX);
                    Height = Math.Abs(RBY - RTY);

                    RegionInfo regionInfo = new RegionInfo()
                    {
                        X = RTX,
                        Y = RTY,
                        Width = Width,
                        Height = Height,
                        type = Types.Value.type
                    };

                    info[i] = regionInfo;
                    i++;
                }

                return info;
            }
            else
            {
                return null;
            }
        }
    }
}

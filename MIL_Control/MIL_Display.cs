using Matrox.MatroxImagingLibrary;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Global;
using System.Security.Policy;
using System.Windows.Controls;
using System.Windows.Shapes;


namespace Vision.MIL_Control
{
    public class MIL_Display
    {
        public MIL_ID milSystem = MIL.M_NULL;          
        public MIL_ID milDisplay = MIL.M_NULL;                                  
        public MIL_ID milGraphicContext = MIL.M_NULL;  
        public MIL_ID milGraphicList = MIL.M_NULL;     
        public MIL_ID mil_MainImage = MIL.M_NULL;
        public MIL_ID mil_DisplayImage = MIL.M_NULL;
        public MIL_ID milOverlayImage = MIL.M_NULL;
        public MIL_ID milMaskImage = MIL.M_NULL;



        private MIL_ImageControl ImageView;
        private MIL_ObjectControl InteractControl;

        private IntPtr Display_Handle;

        private bool DrawMode
        {
            get 
            {
                return Global.Common.TeachingMode;
            }
            set 
            {
                Global.Common.TeachingMode = value;
            }
        }
        
        
        public MIL_Display(Size display,Size Image) 
        {
            Display_Handle = IntPtr.Zero;
            ImageView = new MIL_ImageControl(display,Image);
            InteractControl = new MIL_ObjectControl();
            DrawMode = false;
        }

        public void Set_Display_Handle(IntPtr handle)
        {
            Display_Handle = handle;
        }

        public void StartMIL()
        {
            // 시스템
            MIL.MsysAlloc(MIL.M_DEFAULT, "M_SYSTEM_HOST", MIL.M_DEFAULT, MIL.M_DEFAULT, ref milSystem);

            // 디스플레이
            MIL.MdispAlloc(milSystem, MIL.M_DEFAULT, "M_DEFAULT", MIL.M_WINDOWED, ref milDisplay);

            // 버퍼할당
            MIL.MbufAllocColor(milSystem, (MIL_INT)1, (MIL_INT)8192, (MIL_INT)20000, 32 + MIL.M_UNSIGNED, MIL.M_IMAGE + MIL.M_DISP, ref mil_MainImage);
            MIL.MbufAllocColor(milSystem, (MIL_INT)1, (MIL_INT)8192, (MIL_INT)20000, 32 + MIL.M_UNSIGNED, MIL.M_IMAGE + MIL.M_DISP, ref mil_DisplayImage);
            MIL.MbufAlloc2d(milSystem, 8192, 20000, 1 + MIL.M_UNSIGNED, MIL.M_IMAGE + MIL.M_PROC, ref milMaskImage);
            MIL.MbufClear(mil_MainImage, 0);
            MIL.MbufClear(mil_DisplayImage, 0);
            MIL.MdispSelectWindow(milDisplay, mil_MainImage, Display_Handle);

            MIL.MgraAlloc(milSystem, ref milGraphicContext);

            MIL.MdispControl(milDisplay, MIL.M_OVERLAY, MIL.M_ENABLE);
            MIL.MdispInquire(milDisplay, MIL.M_OVERLAY_ID, ref milOverlayImage);

            //MIL.MdispControl(milDisplay, MIL.M_OVERLAY, MIL.M_ENABLE);
            //MIL.MdispControl(milDisplay, MIL.M_OVERLAY_CLEAR, MIL.M_DEFAULT);
            //MIL.MdispControl(milDisplay, MIL.M_OVERLAY_SHOW, MIL.M_DISABLE);

            MIL.MgraAllocList(milSystem, MIL.M_DEFAULT, ref milGraphicList);
            MIL.MdispControl(milDisplay, MIL.M_ASSOCIATED_GRAPHIC_LIST_ID, milGraphicList);
            MIL.MdispControl(milDisplay, MIL.M_CENTER_DISPLAY, MIL.M_ENABLE);
            MIL.MdispControl(milDisplay, MIL.M_UPDATE_SYNCHRONIZATION, MIL.M_ASYNCHRONOUS);
            //MIL.MdispControl(milDisplay, MIL.M_UPDATE, MIL.M_DISABLE);

            // 회전 불가능
            MIL.MgraControl(milGraphicContext, MIL.M_ROTATABLE, MIL.M_DISABLE);
            MIL.MgraControl(milGraphicContext, MIL.M_SPECIFIC_FEATURES_EDITABLE, MIL.M_DISABLE);

            // 폰트
            //MIL.MgraFont(milGraphicContext, "Arial" );

            // 키 사용 가능
            MIL.MgraControlList(milGraphicList, MIL.M_LIST, MIL.M_DEFAULT, MIL.M_ACTION_KEYS, MIL.M_ENABLE);

            // 삭제 키 기능
            MIL.MgraControlList(milGraphicList, MIL.M_LIST, MIL.M_DEFAULT, MIL.M_ACTION_KEY_DELETE, MIL.M_KEY_DELETE);

            ImageView.mil_MainImage = mil_MainImage;
            ImageView.mil_DisplayImage = mil_DisplayImage;
            ImageView.milDisplay = milDisplay;

            InteractControl.milDisplay = milDisplay;
            InteractControl.milGraphicContext = milGraphicContext;
            InteractControl.milGraphicList = milGraphicList;
        }

        public void EndMIL()
        {
            ImageView.EndMIL();

            MIL.MbufFree(milMaskImage);
            MIL.MgraFree(milGraphicList);
            MIL.MgraFree(milGraphicContext);
            MIL.MdispSelect(milDisplay, MIL.M_NULL);
            MIL.MdispFree(milDisplay);
            MIL.MsysFree(milSystem);
        }
        
        public void Set_Display_Size(Size sz)
        {
            ImageView.Set_Display_Size(sz);
        }

        public void Zoom_In(Point pt)
        {
            ImageView.Zoom_In(pt);
        }

        public void Zoom_Out(Point pt)
        {
            ImageView.Zoom_Out(pt);
        }

        public void LoadImage(string path)
        {
            ImageView.LoadImage(path);
        }

        public void Clear_Interactive()
        {
            InteractControl.Clear_Interactive();
        }

        public void Create_Interacrtive_Rect(RegionType type, double x, double y, double width, double height)
        {
            InteractControl.Set_Interactive_Color(GlobalInstance.Get_Selected_Recipe().Region[type].Color);
            InteractControl.Create_Rect(type, x, y, width, height);
        }
        public void Create_Interacrtive_Strip(double x, double y, double width, double height)
        {
            InteractControl.Set_Interactive_Color(GlobalInstance.Get_Selected_Recipe().Region[RegionType.Area].Color);
            InteractControl.Create_StripRegion(x, y, width, height);
        }

        public Point GetPos()
        {
            return ImageView.GetPos();
        }

        public void SetPos(Point pt)
        {
            ImageView.SetPos(pt);
        }

        public double GetZoomScale()
        {
            return ImageView.GetZoomScale();
        }

        public void Draw()
        {
            ImageView.Draw();
        } 

        public void Test()
        {
            MIL.MdispControl(milDisplay, MIL.M_ASSOCIATED_GRAPHIC_LIST_ID, milGraphicList);
        }

        public void SetDrawMode_Rectangle()
        {
            if (DrawMode)
            {
                MIL.MgraColor(milGraphicContext, MIL.M_COLOR_LIGHT_BLUE);
                MIL.MgraInteractive(milGraphicContext, milGraphicList, MIL.M_GRAPHIC_TYPE_RECT, MIL.M_DEFAULT, MIL.M_ORIENTED_RECT);
            }
        }
        public void SetDrawMode_Circle()
        {
            if (DrawMode)
            {
                MIL.MgraColor(milGraphicContext, MIL.M_COLOR_YELLOW);
                MIL.MgraInteractive(milGraphicContext, milGraphicList, MIL.M_GRAPHIC_TYPE_ARC, MIL.M_DEFAULT, MIL.M_CIRCLE);
                //mPrimitiveInCreation = MIL.M_CIRCLE;
            }
        }

        public Point ViewPt_to_ImagePt(Point pt)
        {
            return ImageView.ViewPt_to_ImagePt(pt);
        }

        public Point ImagePt_To_ViewPt(Point pt)
        {
            return ImageView.ImagePt_To_ViewPt(pt);
        }

        public void SetTeachingMode(bool Draw)
        {
            MIL.MdispControl(milDisplay, MIL.M_OVERLAY_CLEAR, MIL.M_DEFAULT);
            ImageView.SetTeachingMode(Draw);
            InteractControl.SetTeachingMode(Draw);
        }

        public void Set_Current_RegionType(int Type)
        {
            InteractControl.Set_Current_RegionType(Type);
        }

        public RegionInfo[] Get_Region_Info()
        {
            return InteractControl.Apply_Current_Interactive_to_Region();
        }

        public void ToggleViewMode_WH(bool b)
        {
            ImageView.ToggleViewMode_WH(b);
        }

        public void Set_ZeroPosition()
        {
            ImageView.Set_ZeroPosition();
        }
    }
}

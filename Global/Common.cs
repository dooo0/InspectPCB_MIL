using Matrox.MatroxImagingLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using static Global.GlobalInstance;

namespace Global
{
    // Enum
    public enum PathList
    {
        Recipe = 0, Recipe_Top, Recipe_Bottom, Log, System
    }

    public enum MachineType
    {
        Sorter = 0, HDI_Sorter, Laser
    }

    enum InspectType
    {
        None = 0,
        Binary = 1,
        Reference = 2
    }

    public enum RegionType : int
    {
        None = -1,
        Area = 0,
        Barcode,
        MapID_Inside,
        MapID_Outside,
        NoInspect_Inside,
        NoInspect_Outside,
        Laser ,
        Mix,
        Reference ,
        Scratch,
        Count
    }

    public enum StripResult : int
    {
        Good = 0,
        XOut ,
        Laser
    }


    public struct RegionInfo
    {
        public int index;
        public double X;
        public double Y;
        public double Width;
        public double Height;
        public RegionType type;
    }



    public class Common
    {
        public static Color Color_RunBtn_Stop = Color.FromArgb(255, 128, 128);
        public static Color Color_RunBtn_Run = Color.FromArgb(128, 104, 238);
        public static Color Color_View = Color.FromArgb(230, 230, 230);

        public static bool TeachingMode = false;

        //public static GlobalInstance GInstance = new GlobalInstance();

        public static String GetPath(PathList pathList, bool bUseSlash = true)
        {
            String sPath = "";
            String sSlash = (bUseSlash == true ? "\\" : "");

            switch (pathList)
            {
                case PathList.Recipe:
                    sPath = GlobalInstance.sDataPath + "Recipe" + sSlash;
                    break;
                case PathList.Recipe_Top:
                    sPath = GlobalInstance.sDataPath + "Recipe\\" + "Top" + sSlash;
                    break;
                case PathList.Recipe_Bottom:
                    sPath = GlobalInstance.sDataPath + "Recipe\\" + "Bottom" + sSlash;
                    break;
                case PathList.Log:
                    sPath = GlobalInstance.sDataPath + "Log" + sSlash;
                    break;
                case PathList.System:
                    sPath = GlobalInstance.sDataPath + "System" + sSlash;
                    break;
            }

            return sPath;
        }

        public static DialogResult ShowMsgBox(string msg)
        {
            // using construct ensures the resources are freed when form is closed
            using (var form = new Vision.Forms.Form_MessageBox(msg))
            {
                form.ShowDialog();
                DialogResult result = form.DialogResult;
                form.Close();
                form.Dispose();
                return result;
            }
        }        

        public static string RegionType_to_String(RegionType regionType)
        {
            string s = "";

            switch (regionType)
            {
                case RegionType.None:
                    s = "None";
                    break;
                case RegionType.Area:
                    s = "검사영역";
                    break;
                case RegionType.Barcode:
                    s = "바코드";
                    break;
                case RegionType.MapID_Inside:
                    s = "맵아이디";
                    break;
                case RegionType.MapID_Outside:
                    s = "유닛맵아이디";
                    break;
                case RegionType.NoInspect_Inside:
                    s = "내부검사제외";
                    break;
                case RegionType.NoInspect_Outside:
                    s = "외부검사제외";
                    break;
                case RegionType.Laser:
                    s = "레이저";
                    break;
                case RegionType.Mix:
                    s = "혼입";
                    break;
                case RegionType.Reference:
                    s = "레퍼런스";
                    break;
                case RegionType.Scratch:
                    s = "스크래치";
                    break;
            }

            return s;
        }

        public static RegionType String_to_RegionType(string s)
        {
            RegionType regionType = RegionType.None;

            switch (s)
            {
                case "None":
                    regionType = RegionType.None;
                    break;
                case "검사영역":
                    regionType = RegionType.Area;
                    break;
                case "바코드":
                    regionType = RegionType.Barcode;
                    break;
                case "맵아이디":
                    regionType = RegionType.MapID_Inside;
                    break;
                case "유닛맵아이디":
                    regionType = RegionType.MapID_Outside;
                    break;
                case "내부검사제외":
                    regionType = RegionType.NoInspect_Inside;
                    break;
                case "외부검사제외":
                    regionType = RegionType.NoInspect_Outside;
                    break;
                case "레이저":
                    regionType = RegionType.Laser;
                    break;
                case "혼입":
                    regionType = RegionType.Mix;
                    break;
                case "레퍼런스":
                    regionType = RegionType.Reference;
                    break;
                case "스크래치":
                    regionType = RegionType.Scratch;
                    break;
            }

            return regionType;
        }
        
        public static bool IsEvenNumber(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}


using Matrox.MatroxImagingLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using Vision.ROI;
using Grabber;
using Vision.MIL_Control;
using Vision.Sequence;
using Vision.SystemsInfo;
using Matrox.Imaging.ObjectMil;

namespace Global
{
    public static class GlobalInstance
    {
        public static int ViewCount = 10;
        public static string ButtonName = string.Format("TestBtn");
        public static Size szScreen = Screen.PrimaryScreen.Bounds.Size;
        public static int CommandFrmWidth = 0;
        public static int CommandFrmHeight = 0;
        public static int Mode = 0;
        public static bool Run = false;

        public static List<Recipe> Recipe;
        public static int Count_Camera = 2;

        // Camera
        public static List<Camera_Insterface> Camera = null;

        // MIL variables 
        private static MIL_ID milApplication = MIL.M_NULL;     
        public static List<MIL_Display> MIL_Display = null;

        // Path
        public static String sDataPath = "C:\\VisionData\\";

        // Seq
        public static List<Sequence_Interface> Seq;

        // System
        public static System_Info SystemInfo;

        public static void InitGlobalInstance()
        {
            SystemInfo = new System_Info();
            SystemInfo.LoadSystemInfo();

            Recipe = new List<Recipe>();
            Seq = new List<Sequence_Interface>();
            Camera = new List<Camera_Insterface>();
            MIL_Display = new List<MIL_Display>();

            for (int i = 0; i < Count_Camera; i++)
            {
                // 레시피 초기화
                Recipe rcp = new Recipe(i);
                rcp.RecipeInit();                
                Recipe.Add(rcp);
                Camera.Add(new Camera_Insterface());

                switch(SystemInfo.InspectType)
                {
                    case MachineType.Sorter:
                        Sequence_Sorter Seq_Sorter = new Sequence_Sorter(i);
                        Seq.Add(Seq_Sorter);
                        break;
                    case MachineType.Laser:
                        Sequence_Laser Seq_Laser = new Sequence_Laser(i);
                        Seq.Add(Seq_Laser);
                        break;
                }
            }

            MIL_InitInstance();
        }

        public static Recipe Get_Selected_Recipe()
        {
            return Recipe[Mode];
        }

        public static void GlobalFree()
        {
            MIL_Free();
        }

        public static void MIL_InitInstance()
        {
            MIL.MappAlloc(MIL.M_NULL, MIL.M_DEFAULT, ref milApplication);
            for(int i = 0; i < Count_Camera;i++)
            {
                MIL_Display disp = new MIL_Display(new Size(0,0), Camera[i].imgSize);
                MIL_Display.Add(disp);

            }
        }

        public static void MIL_Free()
        {
            for (int i = 0; i < Count_Camera; i++)
            {
                Recipe[i].Inspector.EndMIL();
                MIL_Display[i].EndMIL();
            }

            MIL.MappFree(milApplication);
        }
    }
}
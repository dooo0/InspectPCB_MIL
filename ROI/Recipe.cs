using Global;
using Matrox.MatroxImagingLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Vision.ROI;
using Vision.MIL_Control;
using Vision.ROI.Inspect_Module;
using System.Windows.Markup;
using System.Windows.Media;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Shapes;
using System.Dynamic;

namespace Vision.ROI
{
    public class Recipe
    {
        public int Index = 0; // Top : 0 , Bottom : 1
        public string RecipePath = "C:\\VisionData\\Recipe\\";
        public string FileName;
        public Image Img = null;
        private bool enable = false;
        private BinaryFormatter ROIFormatter = new BinaryFormatter();


        public bool Enable
        {
            get { return enable; }
        }

        public int XCount
        {
            get { return ((Inspect_Area)Region[RegionType.Area]).X_Count; }
            set { ((Inspect_Area)Region[RegionType.Area]).X_Count = value; }
        } 

        public int YCount
        {
            get { return ((Inspect_Area)Region[RegionType.Area]).Y_Count; }
            set { ((Inspect_Area)Region[RegionType.Area]).Y_Count = value; }
        }

        public int XBlockCount
        {
            get { return ((Inspect_Area)Region[RegionType.Area]).X_Block_Count; }
            set { ((Inspect_Area)Region[RegionType.Area]).X_Block_Count = value; }
        } 
        public int YBlockCount
        {
            get { return ((Inspect_Area)Region[RegionType.Area]).Y_Block_Count; }
            set { ((Inspect_Area)Region[RegionType.Area]).Y_Block_Count = value; }
        }

        public MIL_Inspector Inspector;
        public Dictionary<RegionType, Vision.ROI.ROI> Region;

        public Recipe(int idx)
        {
            Index = idx;
        }


        public void RecipeInit()
        {
            Region = new Dictionary<RegionType, Vision.ROI.ROI>();

            int RegionCount = (int)RegionType.Count;
            for(int i = 0; i < RegionCount; i++)
            {
                Vision.ROI.ROI roi;
                switch((RegionType)i)
                {
                    case RegionType.Area:
                        roi = new Inspect_Area();
                        break;
                    case RegionType.Barcode:
                        roi = new Inspect_Barcode();
                        break;
                    case RegionType.MapID_Inside:
                        roi = new Inspect_MapID_Inside();
                        break;
                    case RegionType.MapID_Outside:
                        roi = new Inspect_MapID_Outside();
                        break;
                    case RegionType.NoInspect_Inside:
                        roi = new Inspect_NoInspectArea_Inside();
                        break;
                    case RegionType.NoInspect_Outside:
                        roi = new Inspect_NoInspectArea_Outside();
                        break;
                    case RegionType.Laser:
                        roi = new Inspect_Laser();
                        break;
                    case RegionType.Mix:
                        roi = new Inspect_Mix();
                        break;
                    case RegionType.Reference:
                        roi = new Inspect_Reference();
                        break;
                    case RegionType.Scratch:
                        roi = new Inspect_Scratch();
                        break;
                    default:
                        roi = new Vision.ROI.ROI();
                        break;
                }

                if(roi != null)
                {
                    Region.Add((RegionType)i,roi);
                }
            }

            Inspector = new MIL_Inspector(ref Region);
    }

        public bool LoadRecipe(int RecipeNum)
        {
            Clear_All_Region();

            string Position = (Index == 0 ? "Top\\" : "Bottom\\");
            string Num = RecipeNum.ToString("D4");

            string folder = RecipePath + Position + Num + "\\";
            string imgPath = folder + Num +  ".bmp";
            string param = folder + Num + ".info";

            try
            {
                GlobalInstance.MIL_Display[Index].LoadImage(imgPath);
            }
            catch
            {
                return false;
            }

            // using (BinaryReader fs = new BinaryReader(new FileStream(param, FileMode.OpenOrCreate)))
            using (Stream stream = File.Open(param, FileMode.OpenOrCreate))
            {
                try
                {
                    GlobalInstance.MIL_Display[Index].Clear_Interactive();

                    //foreach (var rgn in Region.Values)
                    for(int i = 0; i < (int)RegionType.Count; i++) 
                    {

                        //rgn.Load(fs);
                        //
                        switch ((RegionType)i)
                        {
                            case RegionType.None:
                                Region[(RegionType)i] = (ROI)ROIFormatter.Deserialize(stream);
                                break;
                            case RegionType.Area:
                                Region[(RegionType)i] = (Inspect_Area)ROIFormatter.Deserialize(stream);
                                break;
                            case RegionType.Barcode:
                                Region[(RegionType)i] = (Inspect_Barcode)ROIFormatter.Deserialize(stream);
                                break;
                            case RegionType.MapID_Inside:
                                Region[(RegionType)i] = (Inspect_MapID_Inside)ROIFormatter.Deserialize(stream);
                                break;
                            case RegionType.MapID_Outside:
                                Region[(RegionType)i] = (Inspect_MapID_Outside)ROIFormatter.Deserialize(stream);
                                break;
                            case RegionType.NoInspect_Inside:
                                Region[(RegionType)i] = (Inspect_NoInspectArea_Inside)ROIFormatter.Deserialize(stream);
                                break;
                            case RegionType.NoInspect_Outside:
                                Region[(RegionType)i] = (Inspect_NoInspectArea_Outside)ROIFormatter.Deserialize(stream);
                                break;
                            case RegionType.Laser:
                                Region[(RegionType)i] = (Inspect_Laser)ROIFormatter.Deserialize(stream);
                                break;
                            case RegionType.Mix:
                                Region[(RegionType)i] = (Inspect_Mix)ROIFormatter.Deserialize(stream);
                                break;
                            case RegionType.Reference:
                                Region[(RegionType)i] = (Inspect_Reference)ROIFormatter.Deserialize(stream);
                                break;
                            case RegionType.Scratch:
                                Region[(RegionType)i] = (Inspect_Scratch)ROIFormatter.Deserialize(stream);
                                break;
                        }                       

                        //foreach (var child in rgn.ChildRegion)
                        for(int j = 0; j < Region[(RegionType)i].ChildRegion.Count; j++)
                        {
                            double X = Region[(RegionType)i].ChildRegion[j].X;
                            double Y = Region[(RegionType)i].ChildRegion[j].Y;
                            double W = Region[(RegionType)i].ChildRegion[j].Width;
                            double H = Region[(RegionType)i].ChildRegion[j].Height;

                            if ((RegionType)i == RegionType.Area)
                            {
                                GlobalInstance.MIL_Display[Index].Create_Interacrtive_Strip(X, Y, W, H);
                            }
                            else
                            {
                                GlobalInstance.MIL_Display[Index].Create_Interacrtive_Rect((RegionType)i, X, Y, W, H);
                            }
                        }
                    }
                }
                catch
                {
                    return false;
                }
            }

            enable = true;

            return true;
        }

        public void Clear_All_Region()
        {
            foreach(var rgn in Region)
            {
                rgn.Value.Clear_ChildRegion();
            }
        }

        public bool SaveRecipe(int RecipeNum)
        {
            string Position = (Index == 0 ? "Top\\" : "Bottom\\");
            string Num = RecipeNum.ToString("D4");

            string folder = RecipePath + Position + Num + "\\";
            //string imgPath = folder + Num + ".bmp";
            string param = folder + Num + ".info";

            //using (BinaryWriter fs = new BinaryWriter(new FileStream(param, FileMode.Create)))
            using (Stream stream = File.Open(param, FileMode.OpenOrCreate))
            {
                try
                {
                    foreach (var rgn in Region.Values)
                    {
                        //rgn.Save(fs);
                        ROIFormatter.Serialize(stream, rgn);
                    }
                }
                catch
                { 
                    return false; 
                }
            }

            return true;
        }

        public bool Inspect()
        {          
            return Inspector.Inspect(); 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Global;
using System.Drawing;

namespace Vision.ROI.Inspect_Module
{
    [Serializable]
    public class Inspect_Barcode : BarcodeInspect
    {
        public Inspect_Barcode() 
        {
            Color = Color.Purple;
            Type = RegionType.Barcode;
        }

        public override void Load(BinaryReader fs)
        {
            base.Load(fs);

            int Count = fs.ReadInt32();
            for (int i = 0; i < Count; i++)
            {
                ChildRegion.Add(new Inspect_Barcode());
                ChildRegion[i].Load(fs);
            }
        }

        public override void Save(BinaryWriter fs)
        {
            base.Save(fs);

            fs.Write(ChildRegion.Count);
            for (int i = 0; i < ChildRegion.Count; i++)
            {
                ChildRegion[i].Save(fs);
            }
        }
        public override void Create_ChildRegion_From_Point(double x, double y, double width, double height)
        {
            Inspect_Barcode rgn = new Inspect_Barcode()
            {
                X = x,
                Y = y,
                Width = width,
                Height = height
            };

            ChildRegion.Add(rgn);
        }
    }
}

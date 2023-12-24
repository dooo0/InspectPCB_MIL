using Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace Vision.ROI.Inspect_Module
{
    [Serializable]
    public class Inspect_Area : ROI
    {
        public int X_Count;
        public int Y_Count;
        public int X_Block_Count;
        public int Y_Block_Count;
        public StripResult Result;
        

        public double StripWidth
        {
            get { return Width / X_Count; }
        }

        public double StripHeight
        {
            get { return Height / Y_Count; }
        }

        public Inspect_Area() 
        {
            Color = Color.Yellow;

            X_Count = 6;
            Y_Count = 30;
            X_Block_Count = 1;
            Y_Block_Count = 1;

            Type = RegionType.Area;
        }

        public override void Load(BinaryReader fs)
        {
            base.Load(fs);

            X_Count = fs.ReadInt32();
            Y_Count = fs.ReadInt32();
            X_Block_Count = fs.ReadInt32();
            Y_Block_Count = fs.ReadInt32();

            int Count = fs.ReadInt32();
            for (int i = 0; i < Count; i++)
            {
                ChildRegion.Add(new Inspect_Area());
                ChildRegion[i].Load(fs);
            }
        }

        public override void Save(BinaryWriter fs) 
        { 
            base.Save(fs);

            fs.Write(X_Count);
            fs.Write(Y_Count);
            fs.Write(X_Block_Count);
            fs.Write(Y_Block_Count);

            fs.Write(ChildRegion.Count);
            for (int i = 0; i < ChildRegion.Count; i++)
            {
                ChildRegion[i].Save(fs);
            }
        }

        public override void Create_ChildRegion_From_Point(double x, double y, double width, double height)
        {
            Inspect_Area rgn = new Inspect_Area()
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using Global;
using Vision.ROI.Inspect_Module;

namespace Vision.ROI
{
    [Serializable]
    public class Inspect_Scratch : BinaryInspect
    {
        public Inspect_Scratch() 
        {
            Color = Color.YellowGreen;
            Type = RegionType.Scratch;
        }

        override public void Create_ChildRegion_From_Point(double x, double y, double width, double height)
        {
            Inspect_Scratch rgn = new Inspect_Scratch()
            {
                X = x,
                Y = y,
                Width = width,
                Height = height
            };

            ChildRegion.Add(rgn);
        }

        public override void Load(BinaryReader fs)
        {
            base.Load(fs);

            int Count = fs.ReadInt32();
            for (int i = 0; i < Count; i++)
            {
                ChildRegion.Add(new Inspect_Scratch());
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
    }
}

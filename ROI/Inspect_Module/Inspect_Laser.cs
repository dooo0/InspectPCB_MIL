using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using Global;
using Vision.ROI.Inspect_Module;

namespace Vision.ROI
{
    [Serializable]

    public class Inspect_Laser : BinaryInspect
    {
        public Inspect_Laser()
        {
            Color = Color.Cyan;
            Type = RegionType.Laser;
        }

        public override void Create_ChildRegion_From_Point(double x,double y ,double width,double height)
        {
            Inspect_Laser rgn = new Inspect_Laser()
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
                ChildRegion.Add(new Inspect_Laser());
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace Vision.ROI
{
    [Serializable]
    public class BinaryInspect : ROI
    {
        public int GV_Min;
        public int GV_Max;
        public int Area_Min;
        public int Area_Max;

        public BinaryInspect() 
        {
            GV_Min = 128;
            GV_Max = 255;
            Area_Min = 1000;
            Area_Max = 5000;
        }

        public override void Load(BinaryReader fs)
        {
            base.Load(fs);

            GV_Min = fs.ReadInt32();
            GV_Max = fs.ReadInt32();

        }

        public override void Save(BinaryWriter fs)
        {
            base.Save(fs);

            fs.Write(GV_Min);
            fs.Write(GV_Max);
        }
    }
}

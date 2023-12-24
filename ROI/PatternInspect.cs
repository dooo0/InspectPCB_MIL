using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision.ROI
{
    [Serializable]
    public class PatternInspect : ROI
    {
        public PatternInspect() 
        { 

        }

        public override void Load(BinaryReader fs)
        {
            base.Load(fs);
        }

        public override void Save(BinaryWriter fs)
        {
            base.Save(fs);
        }
    }
}

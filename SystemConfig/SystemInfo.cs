using Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Global.Common;

namespace Vision.SystemsInfo
{
    public class System_Info
    {
        public MachineType InspectType = MachineType.Sorter;
        
        public System_Info() 
        { 
            
        }

        public void LoadSystemInfo()
        {
            String sPath = Common.GetPath(PathList.System, false) + "SystemInfo.ini";
            
            InspectType = (MachineType)Convert.ToInt32(Global.INI_Helper.GetValue(sPath, "Info", "InspectType", "0"));
        }

        public void SaveSystemInfo()
        {

        }

    }
}

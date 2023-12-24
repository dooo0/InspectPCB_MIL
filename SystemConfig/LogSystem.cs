using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Global
{
    public class LogSystem
    {
        public static bool Log_Add(string sLog)
        {
            try
            {
                string sDateTime = DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] ");
                string sFileName = DateTime.Now.ToString("yyyy-MM-dd") + " Vision Log.txt";
                string sFolderCheck = Common.GetPath(PathList.Log);

                if(!System.IO.Directory.Exists(sFolderCheck))
                {
                    System.IO.Directory.CreateDirectory(sFolderCheck);
                }

                StreamWriter sw = new StreamWriter(sFolderCheck + sFileName,true);
                
                sLog = sDateTime + sLog;

                sw.WriteLine(sLog);
                sw.Close();
                sw.Dispose();
            }
            catch 
            { 
                return false;
            }
            return true;
        }
    }
}

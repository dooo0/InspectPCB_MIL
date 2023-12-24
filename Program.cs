using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vision.Forms;

namespace Program
{
    public static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Global.GlobalInstance.InitGlobalInstance();

            Form_Loading form_Loading = new Form_Loading();
            form_Loading.Show();
            Application.DoEvents();

            Form_Main form_Main = new Form_Main();
            form_Loading.Close();
            form_Loading.Dispose();

            Application.Run(form_Main);

            Global.GlobalInstance.GlobalFree();
        }
    }
}

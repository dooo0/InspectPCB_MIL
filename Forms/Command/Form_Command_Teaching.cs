using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using Global;
using Vision.CustomControls;

namespace Vision.Forms
{
    public partial class Form_Command_Teaching : System.Windows.Forms.Form
    {
        public Form_Main frmMain;
        public Form_View_Result frmResult;

        public Form_Command_Teaching()
        {
            InitializeComponent();
        }

        private void Btn_teaching_exit_Click(object sender, EventArgs e)
        {
            frmMain.SetViewMode(false);
            //GlobalInstance.MIL_Display[Global.GlobalInstance.Mode].SetTeachingMode(false);
        }

        private void Btn_Region_Click(object sender, EventArgs e)
        {
            RJButton btn = sender as RJButton;
            int SelectedNumber = (int)RegionType.None;

            switch (btn.Tag)
            {
                case "Laser":
                    SelectedNumber = (int)RegionType.Laser;
                    break;
                case "Scratch":
                    SelectedNumber = (int)RegionType.Scratch;
                    break;
                case "Area":
                    SelectedNumber = (int)RegionType.Area;
                    break;
                case "Reference":
                    SelectedNumber = (int)RegionType.Reference;
                    break;
                case "MapID":
                    SelectedNumber = (int)RegionType.MapID_Outside;
                    break;
            }

            GlobalInstance.MIL_Display[GlobalInstance.Mode].Set_Current_RegionType(SelectedNumber);
        }

        private void Btn_Teaching_apply_Click(object sender, EventArgs e)
        {
            RegionInfo[] rgn = GlobalInstance.MIL_Display[GlobalInstance.Mode].Get_Region_Info();
            GlobalInstance.Get_Selected_Recipe().Clear_All_Region();

            if (rgn != null)
            {
                for (int i = 0; i < rgn.Length; i++)
                {
                    GlobalInstance.Get_Selected_Recipe().Region[rgn[i].type].Create_ChildRegion_From_Point(rgn[i].X, rgn[i].Y, rgn[i].Width, rgn[i].Height);
                }
            }
            frmMain.SetViewMode(false);
        }
    }
}

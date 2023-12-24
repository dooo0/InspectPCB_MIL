using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using Global;
using Vision.ROI;
using Vision.CustomControls;
using Vision.Forms.Parameter;

namespace Vision.Forms
{
    public partial class Form_Parameter : System.Windows.Forms.Form
    {
        // 버튼 갯수
        private const int ButtonCount = 4;
               
        // 창움직임
        private bool bMove = false;
        private Point ptStartPosition = new Point(0, 0);
        private Point ptEndPosition = new Point(0, 0);
        private Point ptOffset = new Point(0, 0);

        // 리스트
        private int Page; // 제로베이스
        private int Selected;
        private RJButton[] btns;
        private List<string> RegionList;
        private Dictionary<RegionType, Form_Parameter_Base> RegionForm;

        public Form_Parameter()
        {
            InitializeComponent();

            btns = new RJButton[ButtonCount];
            btns[0] = btn_1;
            btns[1] = btn_2;
            btns[2] = btn_3;
            btns[3] = btn_4;

            Page = 0;
            Selected = 0;

            RegionList = new List<string>();
            RegionForm = new Dictionary<RegionType, Form_Parameter_Base>();

            for (int i= 0; i < (int)RegionType.Count; i++)
            {
                ROI.ROI rgn = GlobalInstance.Recipe[GlobalInstance.Mode].Region[(RegionType)i];
                Form_Parameter_Base form;

                if (rgn is ROI.BinaryInspect)
                {
                    form = new Form_Parameter_Binary((RegionType)i);
                }
                else if (rgn is ROI.Inspect_Module.Inspect_Reference)
                {
                    form = new Form_Parameter_Reference((RegionType)i);
                }
                else
                {
                    form = new Form_Parameter_Reference((RegionType)i);
                }

                form.TopLevel = false;
                this.Controls.Add(form);
                form.Location = this.pic_View.Location;
                RegionForm.Add((RegionType)i, form);
            }
        }


        public void UpdateParameterList()
        {
            RegionList.Clear();

            int Mode = GlobalInstance.Mode;
            for (int i = 0; i < (int)RegionType.Count; i++)
            {
                if (GlobalInstance.Recipe[Mode].Region[(RegionType)i].GetChildRegionCount() > 0)
                {
                    RegionList.Add(Common.RegionType_to_String((RegionType)i));
                }
            }

            SetPage(0);

            if (RegionList.Count > 0)
            {
                ShowChildForm(Common.String_to_RegionType(RegionList[0]));
            }

            foreach (var form in RegionForm.Values)
            {
                form.UpdateData();
            }
        }

        private void SetPage(int page)
        {
            int Count = RegionList.Count;

            int Offset = ButtonCount * page;


            for(int i = Offset; i < Offset + ButtonCount; i++)
            {
                if(i < Count)
                {
                    btns[i - Offset].Show();
                    btns[i - Offset].Text = RegionList[i];
                }
                else
                {
                    btns[i - Offset].Hide();
                }

                if(i == Selected)
                {
                    btns[i - Offset].BackgroundColor = Color.FromArgb(0, 0, 255);
                }
                else
                {
                    btns[i - Offset].BackgroundColor = Color.FromArgb(70, 70, 255);
                }
            }

            Page = page;
        }
        
        private void Btn_SaveParameter(object sender, EventArgs e)
        {
                   
        }

        private void Btn_Close(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmRecipe_Load(object sender, EventArgs e)
        {
            
        }

        private void panel_window_MouseDown(object sender, MouseEventArgs e)
        {
            bMove = true;

            ptOffset.X = 0;
            ptOffset.Y = 0;

            ptStartPosition = e.Location;
        }

        private void panel_window_MouseMove(object sender, MouseEventArgs e)
        {
            if (bMove)
            {
                ptOffset.X = e.X - ptStartPosition.X;
                ptOffset.Y = e.Y - ptStartPosition.Y;

                ptEndPosition.X = this.Location.X + ptOffset.X;
                ptEndPosition.Y = this.Location.Y + ptOffset.Y;

                this.Location = ptEndPosition;
            }
        }

        private void panel_window_MouseUp(object sender, MouseEventArgs e)
        {
            bMove = false;
        }

        private void btn_Preview_Click(object sender, EventArgs e)
        {
            if(Page > 0)
            {
                SetPage(Page-1);
            }
            
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            int Count = RegionList.Count;
            if ((Page+1) * ButtonCount < Count)
            {
                SetPage(Page + 1);
            }
        }

        private void btns_Click(object sender, EventArgs e)
        {
            RJButton btn = (RJButton)sender;
            int Num = Convert.ToInt32(btn.Tag);
            Selected = Num + Page * ButtonCount;
            btn_1.BackgroundColor = Color.FromArgb(70, 70, 255);
            btn_2.BackgroundColor = Color.FromArgb(70, 70, 255);
            btn_3.BackgroundColor = Color.FromArgb(70, 70, 255);
            btn_4.BackgroundColor = Color.FromArgb(70, 70, 255);
            btn.BackgroundColor = Color.FromArgb(0, 0, 255);

            string rgn = RegionList[Page * ButtonCount + Num];
            ShowChildForm(Common.String_to_RegionType(rgn));
        }

        private void ShowChildForm(RegionType regionType)
        {
            foreach(Form form in RegionForm.Values)
            {
                form.Hide();
            }
            RegionForm[regionType].Show();
        }
    }
}

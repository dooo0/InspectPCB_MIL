using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;
using Global;
using Vision.CustomControls;

namespace Vision.Forms
{
    public partial class Form_Command_Main : System.Windows.Forms.Form
    {
        public Form_Recipe frmRecipe;
        public Form_Parameter frmParameter;
        public Form_Main frmMain;
        public List<Form_View_Result> frmResult;

        public Form_Command_Main()
        {
            InitializeComponent();
            
            frmResult = new List<Form_View_Result>();

            int nWidth = GlobalInstance.CommandFrmWidth;
            int nHeight = GlobalInstance.CommandFrmHeight;

            int nLogoHeight = pictureBox_logo.Height;
            int nRunBtnHeight = TglBtn_Run.Height;

            Size szResult = new Size(nWidth - 30, nHeight - 200 - nLogoHeight - nRunBtnHeight);
            Point ptStart = new Point(15, 15 + nLogoHeight + nRunBtnHeight + 70);


            for (int i = 0; i < GlobalInstance.Count_Camera; i++)
            {
                Form_View_Result frm = new Form_View_Result(i);


                frm.TopLevel = false;
                frm.Location = ptStart;
                frm.Size = szResult;

                if (i == GlobalInstance.Mode)
                {
                    frm.Show();
                }
                else
                {
                    frm.Hide();
                }
                this.Controls.Add(frm);

                frmResult.Add(frm);
                
            }

        }

        private void Btn_RecipeFrm(object sender, EventArgs e)
        {
            Size szScreen = Global.GlobalInstance.szScreen;
            Point ptCenter = new Point (szScreen.Width/2 - frmRecipe.Width/2, szScreen.Height/2 - frmRecipe.Height/2);

            frmRecipe.Location = ptCenter;
            frmRecipe.UpdateRecipeList();
            frmRecipe.Show();
            frmRecipe.Location = ptCenter;

        }

        private void Btn_Inspect_Click(object sender, EventArgs e)
        {
            int Mode = GlobalInstance.Mode;
            GlobalInstance.Recipe[Mode].Inspect();
            frmResult[Mode].Invalidate(false);
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            frmMain.Close();
        }

        private void Btn_teaching_Click(object sender, EventArgs e)
        {
            frmMain.SetViewMode(true);
        }

        private void Btn_teaching_MouseDown(object sender, MouseEventArgs e)
        {            

        }

        private void Btn_teaching_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void Btn_recipeshow_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void Btn_recipeshow_MouseDown(object sender, MouseEventArgs e)
        {


        }

        private void TglBtn_Run_CheckedChanged(object sender, EventArgs e)
        {
            GlobalInstance.Run = !GlobalInstance.Run;
            bool bRun = GlobalInstance.Run;

            if(bRun)
            {
                this.label_Run.BackColor = Common.Color_RunBtn_Run;
                this.label_Run.Text = "가 동 중";
                GlobalInstance.Seq[0].Run();
                GlobalInstance.Seq[1].Run();

            }
            else
            {
                this.label_Run.BackColor = Common.Color_RunBtn_Stop;
                this.label_Run.Text = "정 지";
                GlobalInstance.Seq[0].Stop();
                GlobalInstance.Seq[1].Stop();
            }

        }

        private void Form_Command_Main_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form_Command_Main_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form_Command_Main_Load(object sender, EventArgs e)
        {
            btn_Mode_0.Location = new Point(frmResult[0].Location.X, frmResult[0].Location.Y - btn_Mode_0.Size.Height);
            btn_Mode_1.Location = new Point(frmResult[0].Location.X + frmResult[0].Size.Width/2, frmResult[0].Location.Y - btn_Mode_1.Size.Height);
        }

        private void Btn_Mode_Click(object sender, EventArgs e)
        {
            if((RJButton)sender == btn_Mode_0)
            {
                btn_Mode_0.BackColor = Color.FromArgb(0, 0, 0);
                btn_Mode_0.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 0);
                btn_Mode_0.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 0);

                btn_Mode_1.BackColor = Color.FromArgb(50, 50, 50);
                btn_Mode_1.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
                btn_Mode_1.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 50, 50);

                frmResult[0].Show();
                frmResult[1].Hide();

                GlobalInstance.Mode = 0;
            }
            else
            {
                btn_Mode_1.BackColor = Color.FromArgb(0, 0, 0);
                btn_Mode_1.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 0);
                btn_Mode_1.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 0);

                btn_Mode_0.BackColor = Color.FromArgb(50, 50, 50);
                btn_Mode_0.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
                btn_Mode_0.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 50, 50);

                frmResult[0].Hide();
                frmResult[1].Show();

                GlobalInstance.Mode = 1;
            }
        }

        private void btn_parameter_Click(object sender, EventArgs e)
        {
            Size szScreen = Global.GlobalInstance.szScreen;
            Point ptCenter = new Point(szScreen.Width / 2 - frmParameter.Width / 2, szScreen.Height / 2 - frmParameter.Height / 2);

            frmParameter.Location = ptCenter;
            frmParameter.Show();
            frmParameter.Location = ptCenter;
            frmParameter.UpdateParameterList();

        }
    }
}

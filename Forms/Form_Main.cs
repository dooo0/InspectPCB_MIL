using Global;
using Matrox.MatroxImagingLibrary;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
//using System.Windows.Controls;
using System.Windows.Forms;

namespace Vision.Forms
{
    public partial class Form_Main : System.Windows.Forms.Form
    {
        public Form_Command_Image[] Form_Image_UI = new Form_Command_Image[2];
        public Form_Command_Main Form_Command_Main;
        public Form_Recipe Form_Recipe;
        public Form_Parameter Form_Parameter;
        public Form_Command_Teaching Form_Command_Teaching;

        public Size[] FormSizes = new Size[2];
        public Point[] FormPoints = new Point[2];

        public Form_Main()
        { 
            InitializeComponent();

            Size szScreen = GlobalInstance.szScreen;
            Size szSize = new Size(szScreen.Width - 32, szScreen.Height - 32);
            int nCommandWidth = szSize.Width / 5;
            int nImgViewWidth = (szSize.Width - nCommandWidth - 16) / 2;
            GlobalInstance.CommandFrmWidth = nCommandWidth;
            GlobalInstance.CommandFrmHeight = szSize.Height;

            // 레시피 창
            Form_Recipe = new Form_Recipe();
            Form_Recipe.Hide();
            Form_Recipe.TopLevel = true;
            this.AddOwnedForm(Form_Recipe);

            // 파라미터 창
            Form_Parameter = new Form_Parameter();
            Form_Parameter.Hide();
            Form_Parameter.TopLevel = true;
            this.AddOwnedForm(Form_Parameter);

            // 커맨드 창
            Form_Command_Main = new Form_Command_Main();
            Form_Command_Main.Hide();
            Form_Command_Main.TopLevel = false;
            this.Controls.Add(Form_Command_Main);
            Form_Command_Main.StartPosition = FormStartPosition.Manual;
            Form_Command_Main.Location = new Point(16, 16);
            Form_Command_Main.Size = new Size(nCommandWidth, szSize.Height);
            Form_Command_Main.frmRecipe = Form_Recipe;
            Form_Command_Main.frmParameter = Form_Parameter;
            Form_Command_Main.frmMain = this;


            // 티칭 커맨드 창
            Form_Command_Teaching = new Form_Command_Teaching();
            Form_Command_Teaching.Hide();
            Form_Command_Teaching.TopLevel = false;
            this.Controls.Add(Form_Command_Teaching);
            Form_Command_Teaching.StartPosition = FormStartPosition.Manual;
            Form_Command_Teaching.Location = new Point(16, 16);
            Form_Command_Teaching.Size = new Size(nCommandWidth * 2, szSize.Height);
            Form_Command_Teaching.frmMain = this;


            // 이미지 뷰 창
            for (int i = 0; i < 2; i++)
            {
                Form_Image_UI[i] = new Form_Command_Image(i);
                Form_Image_UI[i].Hide();
                Form_Image_UI[i].TopLevel = true;
                this.AddOwnedForm(Form_Image_UI[i]);
                Form_Image_UI[i].StartPosition = FormStartPosition.Manual;
                Form_Image_UI[i].Location = FormPoints[i] = new Point(16 + nCommandWidth + 16 + (nImgViewWidth * i), 16);
                Form_Image_UI[i].Size = FormSizes[i] = new Size(nImgViewWidth, szSize.Height);

            }

            Global.LogSystem.Log_Add("System Start");
        }
        private void Form_Main_Load(object sender, EventArgs e)
        {
            Form_Image_UI[0].Show();
            Form_Image_UI[1].Show();
            Form_Command_Main.Show();
            Form_Command_Teaching.Hide();
        }

        public void SetViewMode(bool bTeachMode)
        {
            int nCamCount = GlobalInstance.Count_Camera;
            if (bTeachMode == true)
            {
                for (int i = 0; i < nCamCount; i++)
                {
                    if (i == GlobalInstance.Mode)
                    {
                        Form_Image_UI[i].Show();
                        Form_Image_UI[i].Location = new Point(16 + Form_Command_Teaching.Size.Width, Form_Image_UI[0].Location.Y );//Form_Image_UI[0].Location;

                        Size size = new Size((int)(Form_Image_UI[i].Size.Width * 1.5) , Form_Image_UI[i].Height);
                        Form_Image_UI[i].Size = size;
                        //Form_Image_UI[i].BackColor = Form_Command_Teaching.BackColor;
                        Form_Image_UI[i].Form_Image.SetTeachingMode(true);
                    }
                    else
                    {
                        Form_Image_UI[i].Hide();
                    }

                    Form_Image_UI[i].Form_Image.Set_ZeroPosition();
                }

                Form_Command_Main.Hide();
                Form_Command_Teaching.Show();
            }
            else
            {
                for (int i = 0; i < GlobalInstance.Count_Camera; i++)
                {
                    Form_Image_UI[i].Show();
                    Form_Image_UI[i].Size = FormSizes[i];
                    Form_Image_UI[i].Location = FormPoints[i];

                    if (i == GlobalInstance.Mode)
                    {
                        Form_Image_UI[i].Form_Image.SetTeachingMode(false);
                        //Form_Image_UI[i].BackColor = Common.Color_View;
                    }

                    Form_Image_UI[i].Form_Image.Set_ZeroPosition();
                }

                Form_Command_Main.Show();
                Form_Command_Teaching.Hide();
            }

        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {
                Form_Image_UI[i].Close();
                Form_Image_UI[i].Dispose();
            }

            Form_Command_Main.Close();
            Form_Command_Teaching.Close();
            Form_Recipe.Close();
            Form_Parameter.Close();

            Form_Command_Main.Dispose();
            Form_Command_Teaching.Dispose();
            Form_Recipe.Dispose();
            Form_Parameter.Dispose();
        }

        private void Form_Main_KeyDown(object sender, KeyEventArgs e)
        {

            
        }

        
    }
}
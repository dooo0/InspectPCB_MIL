using System;
using System.Windows.Forms;
using Vision.CustomControls;

namespace Vision.Forms
{        
    public partial class Form_Command_Image : System.Windows.Forms.Form
    {
        private int Index = 0;
        public Form_Image Form_Image;

        public Form_Command_Image(int Idx)
        {
            InitializeComponent();

            Index = Idx;

            Form_Image = new Form_Image(Index);
            Form_Image.Hide();
            Form_Image.TopLevel = true;
            Form_Image.StartPosition = FormStartPosition.Manual;
            this.AddOwnedForm(Form_Image);

            label_title.Text = Index == 0 ? "탑" : "바텀";
        }

        private void Form_Load(object sender, EventArgs e)
        {
            
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void FrmImageViewer_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                //contextMenuStrip1.Show(this, e.Location);    // 마우스가 클릭된 지점에서 콘텍스트 메뉴 Show
            }
        }

        private void FrmImageViewer_MouseWheel(object sender, MouseEventArgs e)
        {
            //if (e.Delta > 0)
            //{
            //    disp.Zoom_In(e.Location);
            //}
            //else
            //{
            //    disp.Zoom_Out(e.Location);
            //}            
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    OpenFileDialog openFileDialog = new OpenFileDialog();
            //    openFileDialog.Filter = "(jpg,bmp,png)|*.jpg;*.bmp;*.png;|all files|*.*";
            //    //openFileDialog.InitialDirectory = strUserPath;
            //    openFileDialog.ShowDialog();
            //    if (openFileDialog.FileName != "")
            //    {
            //        disp.LoadImage(openFileDialog.FileName);
            //    }
            //    else
            //    {
            //        ;
            //    }
            //}
            //catch (MILException exception)
            //{
            //    Console.WriteLine("Image Allocation Error : {0}", exception.Message);
            //}
            //catch (Exception err)
            //{
            //    err.Equals(err);
            //}
        }

        private void rjToggleButton1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_imageview_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_window_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void panel_window_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void panel_window_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void panel_imageview_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void panel_imageview_Resize(object sender, EventArgs e)
        {
            if(Form_Image != null)
            {                
                             
            }
        }

        private void panel_imageview_Move(object sender, EventArgs e)
        {
            if (Form_Image != null)
            {
                
            }
        }

        private void Form_View_Image_UI_Move(object sender, EventArgs e)
        {
            if (Form_Image != null)
            {
                System.Drawing.Point pt = new System.Drawing.Point(this.Left + this.panel_imageview.Left, this.Top + this.panel_imageview.Top);
                Form_Image.Location = pt;
            }
        }

        private void Form_View_Image_UI_Resize(object sender, EventArgs e)
        {
            if (Form_Image != null)
            {
                System.Drawing.Size sz = new System.Drawing.Size(this.panel_imageview.Width, this.panel_imageview.Height);
                Form_Image.Size = sz;                
            }
        }

        private void Form_View_Image_UI_VisibleChanged(object sender, EventArgs e)
        {
            if(Visible)
            {
                Form_Image.Visible = true;
            }
            else
            {
                Form_Image.Visible = false;
            }
        }

        private void btn_toggle_WidthView_CheckedChanged(object sender, EventArgs e)
        {
            bool Checked = ((RJToggleButton)sender).Checked;

            Form_Image.ToggleViewMode_WH(Checked);
            Form_Image.Draw();
        }
    }
}

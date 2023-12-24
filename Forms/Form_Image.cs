using System;
using System.Drawing;
using System.Windows.Forms;
using Matrox.MatroxImagingLibrary;
using Vision.MIL_Control;
using Global;
using static Vision.Forms.Form_Main;
using System.Windows.Media.Media3D;

namespace Vision.Forms
{        
    public partial class Form_Image : System.Windows.Forms.Form
    {
        private int Index = 0;
        private bool bMove = false;

        private MIL_Display disp;
        private Point ptStartPosition = new();//Point(0, 0);
        private Point ptStartPan = new Point(0, 0);
        private Point ptEndPosition = new Point(0, 0);
        private Point ptOffset = new Point(0, 0);

        public Form_Image(int Idx)
        {
            InitializeComponent();

            Index = Idx;

            disp = GlobalInstance.MIL_Display[Index];
            disp.Set_Display_Size(this.Size);
            disp.Set_Display_Handle(this.Handle);
            disp.StartMIL();

            GlobalInstance.Recipe[Idx].Inspector.Init(disp);
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

        private void Form__window_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                disp.Zoom_In(e.Location);
            }
            else
            {
                disp.Zoom_Out(e.Location);
            }            
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        public void SetTeachingMode(bool b)
        {
            bMove = false;
            disp.SetTeachingMode(b);
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "(jpg,bmp,png)|*.jpg;*.bmp;*.png;|all files|*.*";

                openFileDialog.ShowDialog();
                if (openFileDialog.FileName != "")
                {                   
                    disp.LoadImage(openFileDialog.FileName);
                }
                else
                {

                }
            }
            catch (MILException exception)
            {
                Console.WriteLine("Image Allocation Error : {0}", exception.Message);
            }
            catch (Exception err)
            {
                err.Equals(err);
            }
        }

        private void Form_window_MouseDown(object sender, MouseEventArgs e)
        {
            bool Teaching = Common.TeachingMode;

            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
            {
                if (Teaching && e.Button == MouseButtons.Left)
                {
                    return;
                }
                else
                {
                    bMove = true;

                    ptOffset.X = 0;
                    ptOffset.Y = 0;

                    ptStartPosition = e.Location;
                    ptStartPan = disp.GetPos();
                }
            }
        }

        private void Form_window_MouseMove(object sender, MouseEventArgs e)
        {
            if (bMove)
            {
                ptOffset.X = e.X - ptStartPosition.X;
                ptOffset.Y = e.Y - ptStartPosition.Y;

                ptEndPosition.X = ptStartPan.X - (int)(ptOffset.X / disp.GetZoomScale());
                ptEndPosition.Y = ptStartPan.Y - (int)(ptOffset.Y / disp.GetZoomScale());

                disp.SetPos(ptEndPosition);

                disp.Draw();
            }
        }

        private void Form_window_MouseUp(object sender, MouseEventArgs e)
        {
            bMove = false;
        }

        private void Form_View_Image_Resize(object sender, EventArgs e)
        {
            if(disp !=  null)
            {
                disp.Set_Display_Size(this.Size);
            } 
        }

        public void ToggleViewMode_WH(bool b)
        {
            disp.ToggleViewMode_WH(b);
        }

        public void Draw()
        {
            disp.Draw();
        }

        public void Set_ZeroPosition()
        {
            disp.Set_ZeroPosition();
        }

        private void Form_Image_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}

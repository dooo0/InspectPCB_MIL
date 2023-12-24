using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vision.Forms
{
    public partial class Form_MessageBox : System.Windows.Forms.Form
    {
        private bool bMove = false;

        private Point ptStartPosition = new Point(0, 0);
        private Point ptEndPosition = new Point(0, 0);
        private Point ptOffset = new Point(0, 0);

        public Form_MessageBox(string Msg)
        {
            InitializeComponent();

            this.label_Message.Text = Msg;
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

        private void button_OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Global;
using Vision.ROI.Inspect_Module;

namespace Vision.Forms
{
    public partial class Form_View_Result : System.Windows.Forms.Form
    {
        public int Index;

        public Brush GreenBrush;
        public Brush RedBrush;

        public Form_View_Result(int idx)
        {
            InitializeComponent();

            Index = idx;

            GreenBrush = new SolidBrush(Color.Green);
            RedBrush = new SolidBrush(Color.Red);

        }

        private void Form_View_Result_Paint(object sender, PaintEventArgs e)
        {
            if (GlobalInstance.Recipe[Index].Enable)
            {
                float X = GlobalInstance.Recipe[Index].XCount;
                float Y = GlobalInstance.Recipe[Index].YCount;

                if (X > 0 && Y > 0)
                {
                    float gap = 2;

                    float RectWidth = (this.Width - (gap * (X + 1))) / X;
                    float RectHeight = (this.Height - (gap * (Y + 1))) / Y;

                    for (int i = 0; i < Y; i++)
                    {
                        for (int j = 0; j < X; j++)
                        {
                            float X1 = RectWidth * j + gap * j + gap;
                            float Y1 = RectHeight * i + gap * i + gap;

                            e.Graphics.FillRectangle(GreenBrush, X1, Y1, RectWidth, RectHeight);
                        }
                    }
                }
            }
        }
    }
}

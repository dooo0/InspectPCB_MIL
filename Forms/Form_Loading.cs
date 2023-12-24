using System.Windows;

namespace Vision.Forms
{
    public partial class Form_Loading : System.Windows.Forms.Form
    {
        public Form_Loading()
        {
            InitializeComponent();
        }

        public void SetProgressbar(int percent)
        {
            this.rjProgressBar1.Value = percent;
        }
    }
}

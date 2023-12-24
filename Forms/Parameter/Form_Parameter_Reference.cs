using Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vision.Forms.Parameter
{
    public partial class Form_Parameter_Reference :  Form_Parameter_Base
    {
        private RegionType Type;
        public Form_Parameter_Reference(RegionType type)
        {
            InitializeComponent();

            Type = type;
        }

        public override void UpdateData()
        {

        }

        public override void SaveData() 
        {

        }
    }
}

using Global;
using System;
using System.Windows.Forms;
using Vision.CustomControls;
using Vision.Forms.Parameter;
using Vision.ROI;

namespace Vision.Forms
{        
    public partial class Form_Parameter_Binary : Form_Parameter_Base
    {
        private RegionType Type;

        public Form_Parameter_Binary(RegionType type)
        {
            InitializeComponent();

            Type = type;

            label_Title.Text = Common.RegionType_to_String(type);
        }

        private void Form_Load(object sender, EventArgs e)
        {

            
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        public override void UpdateData()
        {
            BinaryInspect rgn = (BinaryInspect)GlobalInstance.Get_Selected_Recipe().Region[Type];

            int RegionCount = rgn.GetChildRegionCount();
            if (RegionCount > 0)
            {
                this.comboBox_Index.Items.Clear();
                for (int i = 0; i < RegionCount; i++)
                {
                    this.comboBox_Index.Items.AddRange(new object[] { i + 1 });
                }

                int ThresholdMin = ((BinaryInspect)rgn.ChildRegion[0]).GV_Min;
                int ThresholdMax = ((BinaryInspect)rgn.ChildRegion[0]).GV_Max;
                int AreaMin = ((BinaryInspect)rgn.ChildRegion[0]).Area_Min;
                int AreaMax = ((BinaryInspect)rgn.ChildRegion[0]).Area_Max;

                this.textBox_GVMin.Text = ThresholdMin.ToString();
                this.textBox_GVMax.Text = ThresholdMax.ToString();
                this.textBox_AreaMin.Text = AreaMin.ToString();
                this.textBox_AreaMax.Text = AreaMax.ToString();
            }
        }

        private void comboBox_Index_SelectedIndexChanged(object sender, EventArgs e)
        {
            BinaryInspect rgn = (BinaryInspect)GlobalInstance.Get_Selected_Recipe().Region[Type];
            int i = ((ComboBox)sender).SelectedIndex;

            int ThresholdMin = ((BinaryInspect)rgn.ChildRegion[i]).GV_Min;
            int ThresholdMax = ((BinaryInspect)rgn.ChildRegion[i]).GV_Max;
            int AreaMin = ((BinaryInspect)rgn.ChildRegion[i]).Area_Min;
            int AreaMax = ((BinaryInspect)rgn.ChildRegion[i]).Area_Max;

            this.textBox_GVMin.Text = ThresholdMin.ToString();
            this.textBox_GVMax.Text = ThresholdMax.ToString();
            this.textBox_AreaMin.Text = AreaMin.ToString();
            this.textBox_AreaMax.Text = AreaMax.ToString();
        }
    }
}

namespace Vision.Forms
{
    partial class Form_Parameter_Binary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.trackBar_Min = new System.Windows.Forms.TrackBar();
            this.trackBar_Max = new System.Windows.Forms.TrackBar();
            this.textBox_GVMin = new System.Windows.Forms.TextBox();
            this.textBox_GVMax = new System.Windows.Forms.TextBox();
            this.label_GVMin = new System.Windows.Forms.Label();
            this.label_GVMax = new System.Windows.Forms.Label();
            this.label_sub = new System.Windows.Forms.Label();
            this.label_Title = new System.Windows.Forms.Label();
            this.textBox_AreaMin = new System.Windows.Forms.TextBox();
            this.textBox_AreaMax = new System.Windows.Forms.TextBox();
            this.label_AreaMin = new System.Windows.Forms.Label();
            this.label_AreaMax = new System.Windows.Forms.Label();
            this.comboBox_Index = new System.Windows.Forms.ComboBox();
            this.label_Index = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Max)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar_Min
            // 
            this.trackBar_Min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar_Min.Location = new System.Drawing.Point(186, 119);
            this.trackBar_Min.Maximum = 255;
            this.trackBar_Min.Name = "trackBar_Min";
            this.trackBar_Min.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar_Min.Size = new System.Drawing.Size(152, 45);
            this.trackBar_Min.TabIndex = 0;
            this.trackBar_Min.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // trackBar_Max
            // 
            this.trackBar_Max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar_Max.Location = new System.Drawing.Point(186, 181);
            this.trackBar_Max.Maximum = 255;
            this.trackBar_Max.Name = "trackBar_Max";
            this.trackBar_Max.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar_Max.Size = new System.Drawing.Size(152, 45);
            this.trackBar_Max.TabIndex = 1;
            this.trackBar_Max.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // textBox_GVMin
            // 
            this.textBox_GVMin.Font = new System.Drawing.Font("KoPubWorld돋움체 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_GVMin.Location = new System.Drawing.Point(104, 127);
            this.textBox_GVMin.Name = "textBox_GVMin";
            this.textBox_GVMin.Size = new System.Drawing.Size(70, 28);
            this.textBox_GVMin.TabIndex = 2;
            // 
            // textBox_GVMax
            // 
            this.textBox_GVMax.Font = new System.Drawing.Font("KoPubWorld돋움체 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_GVMax.Location = new System.Drawing.Point(104, 189);
            this.textBox_GVMax.Name = "textBox_GVMax";
            this.textBox_GVMax.Size = new System.Drawing.Size(70, 28);
            this.textBox_GVMax.TabIndex = 3;
            // 
            // label_GVMin
            // 
            this.label_GVMin.AutoSize = true;
            this.label_GVMin.BackColor = System.Drawing.Color.Transparent;
            this.label_GVMin.Font = new System.Drawing.Font("KoPubWorld돋움체 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_GVMin.Location = new System.Drawing.Point(29, 129);
            this.label_GVMin.Name = "label_GVMin";
            this.label_GVMin.Size = new System.Drawing.Size(66, 25);
            this.label_GVMin.TabIndex = 4;
            this.label_GVMin.Text = "GV 최소";
            // 
            // label_GVMax
            // 
            this.label_GVMax.AutoSize = true;
            this.label_GVMax.BackColor = System.Drawing.Color.Transparent;
            this.label_GVMax.Font = new System.Drawing.Font("KoPubWorld돋움체 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_GVMax.Location = new System.Drawing.Point(29, 190);
            this.label_GVMax.Name = "label_GVMax";
            this.label_GVMax.Size = new System.Drawing.Size(66, 25);
            this.label_GVMax.TabIndex = 5;
            this.label_GVMax.Text = "GV 최대";
            // 
            // label_sub
            // 
            this.label_sub.AutoSize = true;
            this.label_sub.BackColor = System.Drawing.Color.Transparent;
            this.label_sub.Font = new System.Drawing.Font("KoPubWorld돋움체 Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_sub.ForeColor = System.Drawing.Color.Black;
            this.label_sub.Location = new System.Drawing.Point(26, 29);
            this.label_sub.Name = "label_sub";
            this.label_sub.Size = new System.Drawing.Size(39, 37);
            this.label_sub.TabIndex = 7;
            this.label_sub.Text = "●";
            this.label_sub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.BackColor = System.Drawing.Color.Transparent;
            this.label_Title.Font = new System.Drawing.Font("KoPubWorld돋움체 Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Title.ForeColor = System.Drawing.Color.Black;
            this.label_Title.Location = new System.Drawing.Point(61, 29);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(101, 37);
            this.label_Title.TabIndex = 8;
            this.label_Title.Text = "파라미터";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_AreaMin
            // 
            this.textBox_AreaMin.Font = new System.Drawing.Font("KoPubWorld돋움체 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_AreaMin.Location = new System.Drawing.Point(473, 127);
            this.textBox_AreaMin.Name = "textBox_AreaMin";
            this.textBox_AreaMin.Size = new System.Drawing.Size(89, 28);
            this.textBox_AreaMin.TabIndex = 10;
            // 
            // textBox_AreaMax
            // 
            this.textBox_AreaMax.Font = new System.Drawing.Font("KoPubWorld돋움체 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_AreaMax.Location = new System.Drawing.Point(473, 189);
            this.textBox_AreaMax.Name = "textBox_AreaMax";
            this.textBox_AreaMax.Size = new System.Drawing.Size(89, 28);
            this.textBox_AreaMax.TabIndex = 11;
            // 
            // label_AreaMin
            // 
            this.label_AreaMin.AutoSize = true;
            this.label_AreaMin.BackColor = System.Drawing.Color.Transparent;
            this.label_AreaMin.Font = new System.Drawing.Font("KoPubWorld돋움체 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_AreaMin.Location = new System.Drawing.Point(381, 129);
            this.label_AreaMin.Name = "label_AreaMin";
            this.label_AreaMin.Size = new System.Drawing.Size(73, 25);
            this.label_AreaMin.TabIndex = 12;
            this.label_AreaMin.Text = "영역 최소";
            // 
            // label_AreaMax
            // 
            this.label_AreaMax.AutoSize = true;
            this.label_AreaMax.BackColor = System.Drawing.Color.Transparent;
            this.label_AreaMax.Font = new System.Drawing.Font("KoPubWorld돋움체 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_AreaMax.Location = new System.Drawing.Point(381, 190);
            this.label_AreaMax.Name = "label_AreaMax";
            this.label_AreaMax.Size = new System.Drawing.Size(73, 25);
            this.label_AreaMax.TabIndex = 13;
            this.label_AreaMax.Text = "영역 최대";
            // 
            // comboBox_Index
            // 
            this.comboBox_Index.Font = new System.Drawing.Font("KoPubWorld돋움체 Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox_Index.FormattingEnabled = true;
            this.comboBox_Index.Location = new System.Drawing.Point(473, 39);
            this.comboBox_Index.Name = "comboBox_Index";
            this.comboBox_Index.Size = new System.Drawing.Size(89, 27);
            this.comboBox_Index.TabIndex = 14;
            this.comboBox_Index.SelectedIndexChanged += new System.EventHandler(this.comboBox_Index_SelectedIndexChanged);
            // 
            // label_Index
            // 
            this.label_Index.AutoSize = true;
            this.label_Index.BackColor = System.Drawing.Color.Transparent;
            this.label_Index.Font = new System.Drawing.Font("KoPubWorld돋움체 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Index.Location = new System.Drawing.Point(414, 41);
            this.label_Index.Name = "label_Index";
            this.label_Index.Size = new System.Drawing.Size(40, 25);
            this.label_Index.TabIndex = 15;
            this.label_Index.Text = "번호";
            // 
            // Form_Parameter_Binary
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(600, 288);
            this.ControlBox = false;
            this.Controls.Add(this.label_Index);
            this.Controls.Add(this.comboBox_Index);
            this.Controls.Add(this.label_AreaMax);
            this.Controls.Add(this.label_AreaMin);
            this.Controls.Add(this.textBox_AreaMax);
            this.Controls.Add(this.textBox_AreaMin);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.label_sub);
            this.Controls.Add(this.label_GVMax);
            this.Controls.Add(this.label_GVMin);
            this.Controls.Add(this.textBox_GVMax);
            this.Controls.Add(this.textBox_GVMin);
            this.Controls.Add(this.trackBar_Max);
            this.Controls.Add(this.trackBar_Min);
            this.Font = new System.Drawing.Font("KoPubWorld돋움체 Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Parameter_Binary";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmImageViewer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_FormClosed);
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Max)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar_Min;
        private System.Windows.Forms.TrackBar trackBar_Max;
        private System.Windows.Forms.TextBox textBox_GVMin;
        private System.Windows.Forms.TextBox textBox_GVMax;
        private System.Windows.Forms.Label label_GVMin;
        private System.Windows.Forms.Label label_GVMax;
        private System.Windows.Forms.Label label_sub;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.TextBox textBox_AreaMin;
        private System.Windows.Forms.TextBox textBox_AreaMax;
        private System.Windows.Forms.Label label_AreaMin;
        private System.Windows.Forms.Label label_AreaMax;
        private System.Windows.Forms.ComboBox comboBox_Index;
        private System.Windows.Forms.Label label_Index;
    }
}
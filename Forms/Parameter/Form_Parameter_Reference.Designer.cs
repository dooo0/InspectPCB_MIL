namespace Vision.Forms.Parameter
{
    partial class Form_Parameter_Reference
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
            this.label_sub = new System.Windows.Forms.Label();
            this.label_Title = new System.Windows.Forms.Label();
            this.label_Area = new System.Windows.Forms.Label();
            this.textBox_Area = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
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
            // label_Area
            // 
            this.label_Area.AutoSize = true;
            this.label_Area.Font = new System.Drawing.Font("KoPubWorld돋움체 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Area.Location = new System.Drawing.Point(65, 149);
            this.label_Area.Name = "label_Area";
            this.label_Area.Size = new System.Drawing.Size(73, 25);
            this.label_Area.TabIndex = 9;
            this.label_Area.Text = "일치율 %";
            // 
            // textBox_Area
            // 
            this.textBox_Area.Font = new System.Drawing.Font("KoPubWorld돋움체 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_Area.Location = new System.Drawing.Point(142, 148);
            this.textBox_Area.Name = "textBox_Area";
            this.textBox_Area.Size = new System.Drawing.Size(89, 28);
            this.textBox_Area.TabIndex = 10;
            // 
            // Form_Parameter_Reference
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(600, 288);
            this.ControlBox = false;
            this.Controls.Add(this.textBox_Area);
            this.Controls.Add(this.label_Area);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.label_sub);
            this.Font = new System.Drawing.Font("KoPubWorld돋움체 Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Parameter_Reference";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmImageViewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_sub;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_Area;
        private System.Windows.Forms.TextBox textBox_Area;
    }
}
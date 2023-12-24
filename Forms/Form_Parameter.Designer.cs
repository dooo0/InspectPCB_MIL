namespace Vision.Forms
{
    partial class Form_Parameter
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel_window = new System.Windows.Forms.Panel();
            this.pic_View = new System.Windows.Forms.PictureBox();
            this.btn_Next = new Vision.CustomControls.RJButton();
            this.btn_Preview = new Vision.CustomControls.RJButton();
            this.btn_1 = new Vision.CustomControls.RJButton();
            this.btn_2 = new Vision.CustomControls.RJButton();
            this.btn_3 = new Vision.CustomControls.RJButton();
            this.btn_4 = new Vision.CustomControls.RJButton();
            this.button3 = new Vision.CustomControls.RJButton();
            this.button1 = new Vision.CustomControls.RJButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pic_View)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("KoPubWorld돋움체 Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "● 파라미터";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_window
            // 
            this.panel_window.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(80)))));
            this.panel_window.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_window.Location = new System.Drawing.Point(0, 0);
            this.panel_window.Name = "panel_window";
            this.panel_window.Size = new System.Drawing.Size(774, 26);
            this.panel_window.TabIndex = 6;
            this.panel_window.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_window_MouseDown);
            this.panel_window.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_window_MouseMove);
            this.panel_window.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_window_MouseUp);
            // 
            // pic_View
            // 
            this.pic_View.Location = new System.Drawing.Point(26, 125);
            this.pic_View.Name = "pic_View";
            this.pic_View.Size = new System.Drawing.Size(600, 288);
            this.pic_View.TabIndex = 13;
            this.pic_View.TabStop = false;
            this.pic_View.Visible = false;
            // 
            // btn_Next
            // 
            this.btn_Next.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Next.BackColor = System.Drawing.Color.Navy;
            this.btn_Next.BackgroundColor = System.Drawing.Color.Navy;
            this.btn_Next.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Next.BorderRadius = 1;
            this.btn_Next.BorderSize = 0;
            this.btn_Next.FlatAppearance.BorderSize = 0;
            this.btn_Next.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.btn_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Next.Font = new System.Drawing.Font("KoPubWorld돋움체 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Next.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.btn_Next.Location = new System.Drawing.Point(570, 83);
            this.btn_Next.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Padding = new System.Windows.Forms.Padding(5, 1, 0, 0);
            this.btn_Next.Size = new System.Drawing.Size(56, 42);
            this.btn_Next.TabIndex = 12;
            this.btn_Next.Text = ">";
            this.btn_Next.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.btn_Next.UseVisualStyleBackColor = false;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Preview
            // 
            this.btn_Preview.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Preview.BackColor = System.Drawing.Color.Navy;
            this.btn_Preview.BackgroundColor = System.Drawing.Color.Navy;
            this.btn_Preview.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Preview.BorderRadius = 1;
            this.btn_Preview.BorderSize = 0;
            this.btn_Preview.FlatAppearance.BorderSize = 0;
            this.btn_Preview.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.btn_Preview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Preview.Font = new System.Drawing.Font("KoPubWorld돋움체 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.btn_Preview.Location = new System.Drawing.Point(26, 83);
            this.btn_Preview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Preview.Name = "btn_Preview";
            this.btn_Preview.Padding = new System.Windows.Forms.Padding(5, 1, 0, 0);
            this.btn_Preview.Size = new System.Drawing.Size(56, 42);
            this.btn_Preview.TabIndex = 11;
            this.btn_Preview.Text = "<";
            this.btn_Preview.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.btn_Preview.UseVisualStyleBackColor = false;
            this.btn_Preview.Click += new System.EventHandler(this.btn_Preview_Click);
            // 
            // btn_1
            // 
            this.btn_1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_1.BackColor = System.Drawing.Color.Blue;
            this.btn_1.BackgroundColor = System.Drawing.Color.Blue;
            this.btn_1.BorderColor = System.Drawing.Color.Transparent;
            this.btn_1.BorderRadius = 1;
            this.btn_1.BorderSize = 0;
            this.btn_1.FlatAppearance.BorderSize = 0;
            this.btn_1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.btn_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_1.Font = new System.Drawing.Font("KoPubWorld돋움체 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.btn_1.Location = new System.Drawing.Point(82, 83);
            this.btn_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_1.Name = "btn_1";
            this.btn_1.Padding = new System.Windows.Forms.Padding(5, 1, 0, 0);
            this.btn_1.Size = new System.Drawing.Size(122, 42);
            this.btn_1.TabIndex = 7;
            this.btn_1.Tag = "0";
            this.btn_1.Text = "버튼1";
            this.btn_1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.btns_Click);
            // 
            // btn_2
            // 
            this.btn_2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.btn_2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.btn_2.BorderColor = System.Drawing.Color.Transparent;
            this.btn_2.BorderRadius = 1;
            this.btn_2.BorderSize = 0;
            this.btn_2.FlatAppearance.BorderSize = 0;
            this.btn_2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.btn_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_2.Font = new System.Drawing.Font("KoPubWorld돋움체 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.btn_2.Location = new System.Drawing.Point(204, 83);
            this.btn_2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_2.Name = "btn_2";
            this.btn_2.Padding = new System.Windows.Forms.Padding(5, 1, 0, 0);
            this.btn_2.Size = new System.Drawing.Size(122, 42);
            this.btn_2.TabIndex = 8;
            this.btn_2.Tag = "1";
            this.btn_2.Text = "버튼2";
            this.btn_2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.btn_2.UseVisualStyleBackColor = false;
            this.btn_2.Click += new System.EventHandler(this.btns_Click);
            // 
            // btn_3
            // 
            this.btn_3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.btn_3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.btn_3.BorderColor = System.Drawing.Color.Transparent;
            this.btn_3.BorderRadius = 1;
            this.btn_3.BorderSize = 0;
            this.btn_3.FlatAppearance.BorderSize = 0;
            this.btn_3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.btn_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_3.Font = new System.Drawing.Font("KoPubWorld돋움체 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.btn_3.Location = new System.Drawing.Point(326, 83);
            this.btn_3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_3.Name = "btn_3";
            this.btn_3.Padding = new System.Windows.Forms.Padding(5, 1, 0, 0);
            this.btn_3.Size = new System.Drawing.Size(122, 42);
            this.btn_3.TabIndex = 9;
            this.btn_3.Tag = "2";
            this.btn_3.Text = "버튼3";
            this.btn_3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.btn_3.UseVisualStyleBackColor = false;
            this.btn_3.Click += new System.EventHandler(this.btns_Click);
            // 
            // btn_4
            // 
            this.btn_4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.btn_4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.btn_4.BorderColor = System.Drawing.Color.Transparent;
            this.btn_4.BorderRadius = 1;
            this.btn_4.BorderSize = 0;
            this.btn_4.FlatAppearance.BorderSize = 0;
            this.btn_4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.btn_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_4.Font = new System.Drawing.Font("KoPubWorld돋움체 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.btn_4.Location = new System.Drawing.Point(448, 83);
            this.btn_4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_4.Name = "btn_4";
            this.btn_4.Padding = new System.Windows.Forms.Padding(5, 1, 0, 0);
            this.btn_4.Size = new System.Drawing.Size(122, 42);
            this.btn_4.TabIndex = 10;
            this.btn_4.Tag = "3";
            this.btn_4.Text = "버튼4";
            this.btn_4.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.btn_4.UseVisualStyleBackColor = false;
            this.btn_4.Click += new System.EventHandler(this.btns_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(134)))), ((int)(((byte)(220)))));
            this.button3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(134)))), ((int)(((byte)(220)))));
            this.button3.BorderColor = System.Drawing.Color.Transparent;
            this.button3.BorderRadius = 1;
            this.button3.BorderSize = 0;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("KoPubWorld돋움체 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.button3.Location = new System.Drawing.Point(639, 369);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.button3.Size = new System.Drawing.Size(122, 42);
            this.button3.TabIndex = 3;
            this.button3.Text = "창 닫기";
            this.button3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Btn_Close);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(134)))), ((int)(((byte)(220)))));
            this.button1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(134)))), ((int)(((byte)(220)))));
            this.button1.BorderColor = System.Drawing.Color.Transparent;
            this.button1.BorderRadius = 1;
            this.button1.BorderSize = 0;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("KoPubWorld돋움체 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(639, 125);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.button1.Size = new System.Drawing.Size(122, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "저장";
            this.button1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Btn_SaveParameter);
            // 
            // Form_Parameter
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(773, 430);
            this.ControlBox = false;
            this.Controls.Add(this.pic_View);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_Preview);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.panel_window);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("KoPubWorld돋움체 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Parameter";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "레시피";
            this.Load += new System.EventHandler(this.FrmRecipe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Vision.CustomControls.RJButton button1;
        private Vision.CustomControls.RJButton button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_window;
        //private CustomControls.RJButton[] btns;
        private CustomControls.RJButton btn_1;
        private CustomControls.RJButton btn_2;
        private CustomControls.RJButton btn_3;
        private CustomControls.RJButton btn_4;
        private CustomControls.RJButton btn_Preview;
        private CustomControls.RJButton btn_Next;
        private System.Windows.Forms.PictureBox pic_View;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}
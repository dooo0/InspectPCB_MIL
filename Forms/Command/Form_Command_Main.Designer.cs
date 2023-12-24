namespace Vision.Forms
{
    partial class Form_Command_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Command_Main));
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.label_Run = new System.Windows.Forms.Label();
            this.TglBtn_Run = new Vision.CustomControls.RJToggleButton();
            this.btn_inspect_config = new Vision.CustomControls.RJButton();
            this.btn_parameter = new Vision.CustomControls.RJButton();
            this.btn_exit = new Vision.CustomControls.RJButton();
            this.btn_teaching = new Vision.CustomControls.RJButton();
            this.btn_Inspect_test = new Vision.CustomControls.RJButton();
            this.btn_recipeshow = new Vision.CustomControls.RJButton();
            this.btn_Mode_0 = new Vision.CustomControls.RJButton();
            this.btn_Mode_1 = new Vision.CustomControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_logo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_logo.BackgroundImage")));
            this.pictureBox_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_logo.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(348, 60);
            this.pictureBox_logo.TabIndex = 8;
            this.pictureBox_logo.TabStop = false;
            // 
            // label_Run
            // 
            this.label_Run.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Run.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label_Run.Enabled = false;
            this.label_Run.Font = new System.Drawing.Font("KoPubWorld돋움체 Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Run.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_Run.Location = new System.Drawing.Point(114, 94);
            this.label_Run.Margin = new System.Windows.Forms.Padding(3);
            this.label_Run.Name = "label_Run";
            this.label_Run.Size = new System.Drawing.Size(156, 27);
            this.label_Run.TabIndex = 10;
            this.label_Run.Text = "정  지";
            this.label_Run.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TglBtn_Run
            // 
            this.TglBtn_Run.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TglBtn_Run.Location = new System.Drawing.Point(12, 90);
            this.TglBtn_Run.MinimumSize = new System.Drawing.Size(45, 22);
            this.TglBtn_Run.Name = "TglBtn_Run";
            this.TglBtn_Run.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TglBtn_Run.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.TglBtn_Run.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.TglBtn_Run.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.TglBtn_Run.Size = new System.Drawing.Size(348, 38);
            this.TglBtn_Run.TabIndex = 9;
            this.TglBtn_Run.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TglBtn_Run.UseVisualStyleBackColor = true;
            this.TglBtn_Run.CheckedChanged += new System.EventHandler(this.TglBtn_Run_CheckedChanged);
            // 
            // btn_inspect_config
            // 
            this.btn_inspect_config.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_inspect_config.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(180)))));
            this.btn_inspect_config.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(180)))));
            this.btn_inspect_config.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_inspect_config.BorderColor = System.Drawing.Color.Transparent;
            this.btn_inspect_config.BorderRadius = 2;
            this.btn_inspect_config.BorderSize = 0;
            this.btn_inspect_config.FlatAppearance.BorderSize = 0;
            this.btn_inspect_config.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_inspect_config.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btn_inspect_config.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btn_inspect_config.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inspect_config.Font = new System.Drawing.Font("KoPubWorld돋움체 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_inspect_config.ForeColor = System.Drawing.Color.White;
            this.btn_inspect_config.Location = new System.Drawing.Point(11, 530);
            this.btn_inspect_config.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_inspect_config.Name = "btn_inspect_config";
            this.btn_inspect_config.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.btn_inspect_config.Size = new System.Drawing.Size(110, 38);
            this.btn_inspect_config.TabIndex = 7;
            this.btn_inspect_config.Text = "검사설정";
            this.btn_inspect_config.TextColor = System.Drawing.Color.White;
            this.btn_inspect_config.UseVisualStyleBackColor = false;
            // 
            // btn_parameter
            // 
            this.btn_parameter.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_parameter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(180)))));
            this.btn_parameter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(180)))));
            this.btn_parameter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_parameter.BorderColor = System.Drawing.Color.Transparent;
            this.btn_parameter.BorderRadius = 2;
            this.btn_parameter.BorderSize = 0;
            this.btn_parameter.FlatAppearance.BorderSize = 0;
            this.btn_parameter.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_parameter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btn_parameter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btn_parameter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_parameter.Font = new System.Drawing.Font("KoPubWorld돋움체 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_parameter.ForeColor = System.Drawing.Color.White;
            this.btn_parameter.Location = new System.Drawing.Point(131, 530);
            this.btn_parameter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_parameter.Name = "btn_parameter";
            this.btn_parameter.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.btn_parameter.Size = new System.Drawing.Size(110, 38);
            this.btn_parameter.TabIndex = 6;
            this.btn_parameter.Text = "파라미터";
            this.btn_parameter.TextColor = System.Drawing.Color.White;
            this.btn_parameter.UseVisualStyleBackColor = false;
            this.btn_parameter.Click += new System.EventHandler(this.btn_parameter_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(180)))));
            this.btn_exit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(180)))));
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_exit.BorderColor = System.Drawing.Color.Transparent;
            this.btn_exit.BorderRadius = 2;
            this.btn_exit.BorderSize = 0;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("KoPubWorld돋움체 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(250, 530);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.btn_exit.Size = new System.Drawing.Size(110, 38);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "종료";
            this.btn_exit.TextColor = System.Drawing.Color.White;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // btn_teaching
            // 
            this.btn_teaching.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_teaching.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(180)))));
            this.btn_teaching.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(180)))));
            this.btn_teaching.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_teaching.BorderColor = System.Drawing.Color.Transparent;
            this.btn_teaching.BorderRadius = 2;
            this.btn_teaching.BorderSize = 0;
            this.btn_teaching.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_teaching.FlatAppearance.BorderSize = 0;
            this.btn_teaching.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_teaching.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btn_teaching.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btn_teaching.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_teaching.Font = new System.Drawing.Font("KoPubWorld돋움체 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_teaching.ForeColor = System.Drawing.Color.White;
            this.btn_teaching.Location = new System.Drawing.Point(131, 481);
            this.btn_teaching.Margin = new System.Windows.Forms.Padding(0);
            this.btn_teaching.Name = "btn_teaching";
            this.btn_teaching.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.btn_teaching.Size = new System.Drawing.Size(110, 38);
            this.btn_teaching.TabIndex = 4;
            this.btn_teaching.Text = "티칭";
            this.btn_teaching.TextColor = System.Drawing.Color.White;
            this.btn_teaching.UseVisualStyleBackColor = false;
            this.btn_teaching.Click += new System.EventHandler(this.Btn_teaching_Click);
            this.btn_teaching.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_teaching_MouseDown);
            this.btn_teaching.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_teaching_MouseUp);
            // 
            // btn_Inspect_test
            // 
            this.btn_Inspect_test.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Inspect_test.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(180)))));
            this.btn_Inspect_test.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(180)))));
            this.btn_Inspect_test.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Inspect_test.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Inspect_test.BorderRadius = 2;
            this.btn_Inspect_test.BorderSize = 0;
            this.btn_Inspect_test.FlatAppearance.BorderSize = 0;
            this.btn_Inspect_test.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_Inspect_test.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btn_Inspect_test.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btn_Inspect_test.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Inspect_test.Font = new System.Drawing.Font("KoPubWorld돋움체 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Inspect_test.ForeColor = System.Drawing.Color.White;
            this.btn_Inspect_test.Location = new System.Drawing.Point(250, 481);
            this.btn_Inspect_test.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Inspect_test.Name = "btn_Inspect_test";
            this.btn_Inspect_test.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.btn_Inspect_test.Size = new System.Drawing.Size(110, 38);
            this.btn_Inspect_test.TabIndex = 3;
            this.btn_Inspect_test.Text = "테스트";
            this.btn_Inspect_test.TextColor = System.Drawing.Color.White;
            this.btn_Inspect_test.UseVisualStyleBackColor = false;
            this.btn_Inspect_test.Click += new System.EventHandler(this.Btn_Inspect_Click);
            // 
            // btn_recipeshow
            // 
            this.btn_recipeshow.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_recipeshow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(180)))));
            this.btn_recipeshow.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(180)))));
            this.btn_recipeshow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_recipeshow.BorderColor = System.Drawing.Color.Transparent;
            this.btn_recipeshow.BorderRadius = 2;
            this.btn_recipeshow.BorderSize = 0;
            this.btn_recipeshow.FlatAppearance.BorderSize = 0;
            this.btn_recipeshow.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_recipeshow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btn_recipeshow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btn_recipeshow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_recipeshow.Font = new System.Drawing.Font("KoPubWorld돋움체 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_recipeshow.ForeColor = System.Drawing.Color.White;
            this.btn_recipeshow.Location = new System.Drawing.Point(11, 481);
            this.btn_recipeshow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_recipeshow.Name = "btn_recipeshow";
            this.btn_recipeshow.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.btn_recipeshow.Size = new System.Drawing.Size(110, 38);
            this.btn_recipeshow.TabIndex = 1;
            this.btn_recipeshow.Text = "레시피";
            this.btn_recipeshow.TextColor = System.Drawing.Color.White;
            this.btn_recipeshow.UseVisualStyleBackColor = false;
            this.btn_recipeshow.Click += new System.EventHandler(this.Btn_RecipeFrm);
            this.btn_recipeshow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_recipeshow_MouseDown);
            this.btn_recipeshow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_recipeshow_MouseUp);
            // 
            // btn_Mode_0
            // 
            this.btn_Mode_0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Mode_0.BackColor = System.Drawing.Color.Black;
            this.btn_Mode_0.BackgroundColor = System.Drawing.Color.Black;
            this.btn_Mode_0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Mode_0.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Mode_0.BorderRadius = 2;
            this.btn_Mode_0.BorderSize = 0;
            this.btn_Mode_0.FlatAppearance.BorderSize = 0;
            this.btn_Mode_0.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_Mode_0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_Mode_0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_Mode_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Mode_0.Font = new System.Drawing.Font("KoPubWorld돋움체 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Mode_0.ForeColor = System.Drawing.Color.White;
            this.btn_Mode_0.Location = new System.Drawing.Point(12, 138);
            this.btn_Mode_0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Mode_0.Name = "btn_Mode_0";
            this.btn_Mode_0.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.btn_Mode_0.Size = new System.Drawing.Size(174, 38);
            this.btn_Mode_0.TabIndex = 11;
            this.btn_Mode_0.Text = "탑";
            this.btn_Mode_0.TextColor = System.Drawing.Color.White;
            this.btn_Mode_0.UseVisualStyleBackColor = false;
            this.btn_Mode_0.Click += new System.EventHandler(this.Btn_Mode_Click);
            // 
            // btn_Mode_1
            // 
            this.btn_Mode_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Mode_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_Mode_1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_Mode_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Mode_1.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Mode_1.BorderRadius = 2;
            this.btn_Mode_1.BorderSize = 0;
            this.btn_Mode_1.FlatAppearance.BorderSize = 0;
            this.btn_Mode_1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_Mode_1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_Mode_1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_Mode_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Mode_1.Font = new System.Drawing.Font("KoPubWorld돋움체 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Mode_1.ForeColor = System.Drawing.Color.White;
            this.btn_Mode_1.Location = new System.Drawing.Point(186, 138);
            this.btn_Mode_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Mode_1.Name = "btn_Mode_1";
            this.btn_Mode_1.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.btn_Mode_1.Size = new System.Drawing.Size(174, 38);
            this.btn_Mode_1.TabIndex = 12;
            this.btn_Mode_1.Text = "바텀";
            this.btn_Mode_1.TextColor = System.Drawing.Color.White;
            this.btn_Mode_1.UseVisualStyleBackColor = false;
            this.btn_Mode_1.Click += new System.EventHandler(this.Btn_Mode_Click);
            // 
            // Form_Command_Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(372, 579);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Mode_1);
            this.Controls.Add(this.btn_Mode_0);
            this.Controls.Add(this.label_Run);
            this.Controls.Add(this.TglBtn_Run);
            this.Controls.Add(this.pictureBox_logo);
            this.Controls.Add(this.btn_inspect_config);
            this.Controls.Add(this.btn_parameter);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_teaching);
            this.Controls.Add(this.btn_Inspect_test);
            this.Controls.Add(this.btn_recipeshow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Command_Main";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "re";
            this.Load += new System.EventHandler(this.Form_Command_Main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Command_Main_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form_Command_Main_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Vision.CustomControls.RJButton btn_recipeshow;
        private Vision.CustomControls.RJButton btn_Inspect_test;
        private Vision.CustomControls.RJButton btn_teaching;
        private Vision.CustomControls.RJButton btn_exit;
        private Vision.CustomControls.RJButton btn_parameter;
        private Vision.CustomControls.RJButton btn_inspect_config;
        private Vision.CustomControls.RJToggleButton TglBtn_Run;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.Label label_Run;
        private CustomControls.RJButton btn_Mode_0;
        private CustomControls.RJButton btn_Mode_1;
    }
}
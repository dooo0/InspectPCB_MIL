namespace Vision.Forms
{
    partial class Form_Command_Teaching
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
            this.btn_teaching_exit = new Vision.CustomControls.RJButton();
            this.btn_Scratch = new Vision.CustomControls.RJButton();
            this.btn_Laser = new Vision.CustomControls.RJButton();
            this.btn_Reference = new Vision.CustomControls.RJButton();
            this.btn_teaching_apply = new Vision.CustomControls.RJButton();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btn_Area = new Vision.CustomControls.RJButton();
            this.btn_MapID = new Vision.CustomControls.RJButton();
            this.SuspendLayout();
            // 
            // btn_teaching_exit
            // 
            this.btn_teaching_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_teaching_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(180)))));
            this.btn_teaching_exit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(180)))));
            this.btn_teaching_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_teaching_exit.BorderColor = System.Drawing.Color.Transparent;
            this.btn_teaching_exit.BorderRadius = 2;
            this.btn_teaching_exit.BorderSize = 0;
            this.btn_teaching_exit.FlatAppearance.BorderSize = 0;
            this.btn_teaching_exit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_teaching_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btn_teaching_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btn_teaching_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_teaching_exit.Font = new System.Drawing.Font("KoPubWorld돋움체 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_teaching_exit.ForeColor = System.Drawing.Color.White;
            this.btn_teaching_exit.Location = new System.Drawing.Point(219, 540);
            this.btn_teaching_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_teaching_exit.Name = "btn_teaching_exit";
            this.btn_teaching_exit.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.btn_teaching_exit.Size = new System.Drawing.Size(110, 38);
            this.btn_teaching_exit.TabIndex = 9;
            this.btn_teaching_exit.Text = "티칭닫기";
            this.btn_teaching_exit.TextColor = System.Drawing.Color.White;
            this.btn_teaching_exit.UseVisualStyleBackColor = false;
            this.btn_teaching_exit.Click += new System.EventHandler(this.Btn_teaching_exit_Click);
            // 
            // btn_Scratch
            // 
            this.btn_Scratch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(180)))));
            this.btn_Scratch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(180)))));
            this.btn_Scratch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Scratch.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Scratch.BorderRadius = 2;
            this.btn_Scratch.BorderSize = 0;
            this.btn_Scratch.FlatAppearance.BorderSize = 0;
            this.btn_Scratch.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_Scratch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btn_Scratch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btn_Scratch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Scratch.Font = new System.Drawing.Font("KoPubWorld돋움체 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Scratch.ForeColor = System.Drawing.Color.White;
            this.btn_Scratch.Location = new System.Drawing.Point(12, 74);
            this.btn_Scratch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Scratch.Name = "btn_Scratch";
            this.btn_Scratch.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.btn_Scratch.Size = new System.Drawing.Size(220, 48);
            this.btn_Scratch.TabIndex = 10;
            this.btn_Scratch.Tag = "Scratch";
            this.btn_Scratch.Text = "스크래치 검사 영역";
            this.btn_Scratch.TextColor = System.Drawing.Color.White;
            this.btn_Scratch.UseVisualStyleBackColor = false;
            this.btn_Scratch.Click += new System.EventHandler(this.Btn_Region_Click);
            // 
            // btn_Laser
            // 
            this.btn_Laser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(180)))));
            this.btn_Laser.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(180)))));
            this.btn_Laser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Laser.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Laser.BorderRadius = 2;
            this.btn_Laser.BorderSize = 0;
            this.btn_Laser.FlatAppearance.BorderSize = 0;
            this.btn_Laser.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_Laser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btn_Laser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btn_Laser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Laser.Font = new System.Drawing.Font("KoPubWorld돋움체 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Laser.ForeColor = System.Drawing.Color.White;
            this.btn_Laser.Location = new System.Drawing.Point(12, 122);
            this.btn_Laser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Laser.Name = "btn_Laser";
            this.btn_Laser.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.btn_Laser.Size = new System.Drawing.Size(220, 48);
            this.btn_Laser.TabIndex = 11;
            this.btn_Laser.Tag = "Laser";
            this.btn_Laser.Text = "레이저 검사 영역";
            this.btn_Laser.TextColor = System.Drawing.Color.White;
            this.btn_Laser.UseVisualStyleBackColor = false;
            this.btn_Laser.Click += new System.EventHandler(this.Btn_Region_Click);
            // 
            // btn_Reference
            // 
            this.btn_Reference.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(180)))));
            this.btn_Reference.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(180)))));
            this.btn_Reference.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Reference.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Reference.BorderRadius = 2;
            this.btn_Reference.BorderSize = 0;
            this.btn_Reference.FlatAppearance.BorderSize = 0;
            this.btn_Reference.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_Reference.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btn_Reference.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btn_Reference.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reference.Font = new System.Drawing.Font("KoPubWorld돋움체 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Reference.ForeColor = System.Drawing.Color.White;
            this.btn_Reference.Location = new System.Drawing.Point(12, 170);
            this.btn_Reference.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Reference.Name = "btn_Reference";
            this.btn_Reference.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.btn_Reference.Size = new System.Drawing.Size(220, 48);
            this.btn_Reference.TabIndex = 12;
            this.btn_Reference.Tag = "Reference";
            this.btn_Reference.Text = "레퍼런스 검사 영역";
            this.btn_Reference.TextColor = System.Drawing.Color.White;
            this.btn_Reference.UseVisualStyleBackColor = false;
            this.btn_Reference.Click += new System.EventHandler(this.Btn_Region_Click);
            // 
            // btn_teaching_apply
            // 
            this.btn_teaching_apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_teaching_apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(180)))));
            this.btn_teaching_apply.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(180)))));
            this.btn_teaching_apply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_teaching_apply.BorderColor = System.Drawing.Color.Transparent;
            this.btn_teaching_apply.BorderRadius = 2;
            this.btn_teaching_apply.BorderSize = 0;
            this.btn_teaching_apply.FlatAppearance.BorderSize = 0;
            this.btn_teaching_apply.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_teaching_apply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btn_teaching_apply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btn_teaching_apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_teaching_apply.Font = new System.Drawing.Font("KoPubWorld돋움체 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_teaching_apply.ForeColor = System.Drawing.Color.White;
            this.btn_teaching_apply.Location = new System.Drawing.Point(103, 540);
            this.btn_teaching_apply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_teaching_apply.Name = "btn_teaching_apply";
            this.btn_teaching_apply.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.btn_teaching_apply.Size = new System.Drawing.Size(110, 38);
            this.btn_teaching_apply.TabIndex = 13;
            this.btn_teaching_apply.Text = "적용";
            this.btn_teaching_apply.TextColor = System.Drawing.Color.White;
            this.btn_teaching_apply.UseVisualStyleBackColor = false;
            this.btn_teaching_apply.Click += new System.EventHandler(this.Btn_Teaching_apply_Click);
            // 
            // btn_Area
            // 
            this.btn_Area.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(180)))));
            this.btn_Area.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(180)))));
            this.btn_Area.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Area.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Area.BorderRadius = 2;
            this.btn_Area.BorderSize = 0;
            this.btn_Area.FlatAppearance.BorderSize = 0;
            this.btn_Area.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_Area.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btn_Area.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btn_Area.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Area.Font = new System.Drawing.Font("KoPubWorld돋움체 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Area.ForeColor = System.Drawing.Color.White;
            this.btn_Area.Location = new System.Drawing.Point(12, 11);
            this.btn_Area.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Area.Name = "btn_Area";
            this.btn_Area.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.btn_Area.Size = new System.Drawing.Size(220, 48);
            this.btn_Area.TabIndex = 14;
            this.btn_Area.Tag = "Area";
            this.btn_Area.Text = "검사 영역";
            this.btn_Area.TextColor = System.Drawing.Color.White;
            this.btn_Area.UseVisualStyleBackColor = false;
            this.btn_Area.Click += new System.EventHandler(this.Btn_Region_Click);
            // 
            // btn_MapID
            // 
            this.btn_MapID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(180)))));
            this.btn_MapID.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(180)))));
            this.btn_MapID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_MapID.BorderColor = System.Drawing.Color.Transparent;
            this.btn_MapID.BorderRadius = 2;
            this.btn_MapID.BorderSize = 0;
            this.btn_MapID.FlatAppearance.BorderSize = 0;
            this.btn_MapID.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_MapID.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btn_MapID.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btn_MapID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MapID.Font = new System.Drawing.Font("KoPubWorld돋움체 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_MapID.ForeColor = System.Drawing.Color.White;
            this.btn_MapID.Location = new System.Drawing.Point(12, 218);
            this.btn_MapID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_MapID.Name = "btn_MapID";
            this.btn_MapID.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.btn_MapID.Size = new System.Drawing.Size(220, 48);
            this.btn_MapID.TabIndex = 15;
            this.btn_MapID.Tag = "MapID";
            this.btn_MapID.Text = "맵아이디 검사 영역";
            this.btn_MapID.TextColor = System.Drawing.Color.White;
            this.btn_MapID.UseVisualStyleBackColor = false;
            // 
            // Form_Command_Teaching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(341, 589);
            this.ControlBox = false;
            this.Controls.Add(this.btn_MapID);
            this.Controls.Add(this.btn_Area);
            this.Controls.Add(this.btn_teaching_apply);
            this.Controls.Add(this.btn_Reference);
            this.Controls.Add(this.btn_Laser);
            this.Controls.Add(this.btn_Scratch);
            this.Controls.Add(this.btn_teaching_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Command_Teaching";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FrmMainCommand";
            this.ResumeLayout(false);

        }

        #endregion
        private CustomControls.RJButton btn_teaching_exit;
        private CustomControls.RJButton btn_Scratch;
        private CustomControls.RJButton btn_Laser;
        private CustomControls.RJButton btn_Reference;
        private CustomControls.RJButton btn_teaching_apply;
        private System.Windows.Forms.FontDialog fontDialog1;
        private CustomControls.RJButton btn_Area;
        private CustomControls.RJButton btn_MapID;
    }
}
namespace Vision.Forms
{
    partial class Form_MessageBox
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
            this.panel_window = new System.Windows.Forms.Panel();
            this.label_Message = new System.Windows.Forms.Label();
            this.button_OK = new Vision.CustomControls.RJButton();
            this.Button_Cancel = new Vision.CustomControls.RJButton();
            this.SuspendLayout();
            // 
            // panel_window
            // 
            this.panel_window.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(80)))));
            this.panel_window.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_window.Location = new System.Drawing.Point(0, 0);
            this.panel_window.Name = "panel_window";
            this.panel_window.Size = new System.Drawing.Size(404, 23);
            this.panel_window.TabIndex = 7;
            this.panel_window.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_window_MouseDown);
            this.panel_window.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_window_MouseMove);
            this.panel_window.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_window_MouseUp);
            // 
            // label_Message
            // 
            this.label_Message.AutoSize = true;
            this.label_Message.ForeColor = System.Drawing.Color.White;
            this.label_Message.Location = new System.Drawing.Point(27, 66);
            this.label_Message.Name = "label_Message";
            this.label_Message.Size = new System.Drawing.Size(84, 25);
            this.label_Message.TabIndex = 8;
            this.label_Message.Text = "Message";
            // 
            // button_OK
            // 
            this.button_OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(150)))));
            this.button_OK.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(150)))));
            this.button_OK.BorderColor = System.Drawing.Color.Transparent;
            this.button_OK.BorderRadius = 1;
            this.button_OK.BorderSize = 0;
            this.button_OK.FlatAppearance.BorderSize = 0;
            this.button_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_OK.Font = new System.Drawing.Font("KoPubWorld돋움체 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_OK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.button_OK.Location = new System.Drawing.Point(211, 160);
            this.button_OK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_OK.Name = "button_OK";
            this.button_OK.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.button_OK.Size = new System.Drawing.Size(87, 28);
            this.button_OK.TabIndex = 9;
            this.button_OK.Text = "확인";
            this.button_OK.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.button_OK.UseVisualStyleBackColor = false;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(150)))));
            this.Button_Cancel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(150)))));
            this.Button_Cancel.BorderColor = System.Drawing.Color.Transparent;
            this.Button_Cancel.BorderRadius = 1;
            this.Button_Cancel.BorderSize = 0;
            this.Button_Cancel.FlatAppearance.BorderSize = 0;
            this.Button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Cancel.Font = new System.Drawing.Font("KoPubWorld돋움체 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Button_Cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.Button_Cancel.Location = new System.Drawing.Point(304, 160);
            this.Button_Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Button_Cancel.Size = new System.Drawing.Size(87, 28);
            this.Button_Cancel.TabIndex = 10;
            this.Button_Cancel.Text = "닫기";
            this.Button_Cancel.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.Button_Cancel.UseVisualStyleBackColor = false;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Form_MessageBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(134)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(403, 201);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.label_Message);
            this.Controls.Add(this.panel_window);
            this.Font = new System.Drawing.Font("KoPubWorld돋움체 Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form_MessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCustomMsgBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_window;
        private System.Windows.Forms.Label label_Message;
        private CustomControls.RJButton button_OK;
        private CustomControls.RJButton Button_Cancel;
    }
}
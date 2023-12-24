namespace Vision.Forms
{
    partial class Form_Command_Image
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.저장하기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.불러오기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.흑백ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openimagedialog = new System.Windows.Forms.OpenFileDialog();
            this.label_title = new System.Windows.Forms.Label();
            this.btn_toggle_WidthView = new Vision.CustomControls.RJToggleButton();
            this.panel_imageview = new Vision.CustomControls.PanelKeyDown();
            this.label_WidthView = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.저장하기ToolStripMenuItem,
            this.불러오기ToolStripMenuItem,
            this.흑백ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 70);
            // 
            // 저장하기ToolStripMenuItem
            // 
            this.저장하기ToolStripMenuItem.Name = "저장하기ToolStripMenuItem";
            this.저장하기ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.저장하기ToolStripMenuItem.Text = "저장하기";
            this.저장하기ToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // 불러오기ToolStripMenuItem
            // 
            this.불러오기ToolStripMenuItem.Name = "불러오기ToolStripMenuItem";
            this.불러오기ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.불러오기ToolStripMenuItem.Text = "불러오기";
            this.불러오기ToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
            // 
            // 흑백ToolStripMenuItem
            // 
            this.흑백ToolStripMenuItem.Name = "흑백ToolStripMenuItem";
            this.흑백ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.흑백ToolStripMenuItem.Text = "흑백";
            // 
            // openimagedialog
            // 
            this.openimagedialog.FileName = "openFileDialog1";
            // 
            // label_title
            // 
            this.label_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("KoPubWorld돋움체 Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_title.Location = new System.Drawing.Point(12, 8);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(32, 32);
            this.label_title.TabIndex = 2;
            this.label_title.Text = "탑";
            // 
            // btn_toggle_WidthView
            // 
            this.btn_toggle_WidthView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_toggle_WidthView.AutoSize = true;
            this.btn_toggle_WidthView.Location = new System.Drawing.Point(510, 14);
            this.btn_toggle_WidthView.MinimumSize = new System.Drawing.Size(45, 22);
            this.btn_toggle_WidthView.Name = "btn_toggle_WidthView";
            this.btn_toggle_WidthView.OffBackColor = System.Drawing.Color.Gray;
            this.btn_toggle_WidthView.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.btn_toggle_WidthView.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_toggle_WidthView.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.btn_toggle_WidthView.Size = new System.Drawing.Size(45, 22);
            this.btn_toggle_WidthView.TabIndex = 4;
            this.btn_toggle_WidthView.UseVisualStyleBackColor = true;
            this.btn_toggle_WidthView.CheckedChanged += new System.EventHandler(this.btn_toggle_WidthView_CheckedChanged);
            // 
            // panel_imageview
            // 
            this.panel_imageview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_imageview.BackColor = System.Drawing.Color.Black;
            this.panel_imageview.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel_imageview.Location = new System.Drawing.Point(15, 49);
            this.panel_imageview.Name = "panel_imageview";
            this.panel_imageview.Size = new System.Drawing.Size(540, 528);
            this.panel_imageview.TabIndex = 1;
            this.panel_imageview.Visible = false;
            this.panel_imageview.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FrmImageViewer_MouseClick);
            this.panel_imageview.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.FrmImageViewer_MouseWheel);
            this.panel_imageview.Move += new System.EventHandler(this.panel_imageview_Move);
            this.panel_imageview.Resize += new System.EventHandler(this.panel_imageview_Resize);
            // 
            // label_WidthView
            // 
            this.label_WidthView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_WidthView.AutoSize = true;
            this.label_WidthView.Font = new System.Drawing.Font("KoPubWorld돋움체 Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_WidthView.Location = new System.Drawing.Point(436, 9);
            this.label_WidthView.Name = "label_WidthView";
            this.label_WidthView.Size = new System.Drawing.Size(68, 32);
            this.label_WidthView.TabIndex = 5;
            this.label_WidthView.Text = "가로뷰";
            // 
            // Form_Command_Image
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(570, 590);
            this.ControlBox = false;
            this.Controls.Add(this.label_WidthView);
            this.Controls.Add(this.btn_toggle_WidthView);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.panel_imageview);
            this.Font = new System.Drawing.Font("KoPubWorld돋움체 Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Command_Image";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmImageViewer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_FormClosed);
            this.Load += new System.EventHandler(this.Form_Load);
            this.VisibleChanged += new System.EventHandler(this.Form_View_Image_UI_VisibleChanged);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FrmImageViewer_MouseClick);
            this.Move += new System.EventHandler(this.Form_View_Image_UI_Move);
            this.Resize += new System.EventHandler(this.Form_View_Image_UI_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 저장하기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 불러오기ToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openimagedialog;
        private System.Windows.Forms.ToolStripMenuItem 흑백ToolStripMenuItem;
        private System.Windows.Forms.Label label_title;
        private CustomControls.RJToggleButton btn_toggle_WidthView;
        private CustomControls.PanelKeyDown panel_imageview;
        private System.Windows.Forms.Label label_WidthView;
    }
}
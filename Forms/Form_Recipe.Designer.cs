namespace Vision.Forms
{
    partial class Form_Recipe
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "0000",
            "한수",
            "HS-0000"}, -1);
            this.listView_RecipeList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new Vision.CustomControls.RJButton();
            this.button2 = new Vision.CustomControls.RJButton();
            this.button1 = new Vision.CustomControls.RJButton();
            this.panel_window = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // listView_RecipeList
            // 
            this.listView_RecipeList.BackColor = System.Drawing.Color.White;
            this.listView_RecipeList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView_RecipeList.Font = new System.Drawing.Font("KoPubWorld돋움체 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listView_RecipeList.FullRowSelect = true;
            this.listView_RecipeList.GridLines = true;
            this.listView_RecipeList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_RecipeList.HideSelection = false;
            this.listView_RecipeList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView_RecipeList.LabelWrap = false;
            this.listView_RecipeList.Location = new System.Drawing.Point(19, 100);
            this.listView_RecipeList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView_RecipeList.MultiSelect = false;
            this.listView_RecipeList.Name = "listView_RecipeList";
            this.listView_RecipeList.Size = new System.Drawing.Size(347, 600);
            this.listView_RecipeList.TabIndex = 4;
            this.listView_RecipeList.UseCompatibleStateImageBehavior = false;
            this.listView_RecipeList.View = System.Windows.Forms.View.Details;
            this.listView_RecipeList.SelectedIndexChanged += new System.EventHandler(this.listView_RecipeList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "번호";
            this.columnHeader1.Width = 49;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "업체";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "자재명";
            this.columnHeader3.Width = 210;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("KoPubWorld돋움체 Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "● 레시피 목록";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(134)))), ((int)(((byte)(220)))));
            this.button3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(134)))), ((int)(((byte)(220)))));
            this.button3.BorderColor = System.Drawing.Color.Transparent;
            this.button3.BorderRadius = 1;
            this.button3.BorderSize = 0;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("KoPubWorld돋움체 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.button3.Location = new System.Drawing.Point(372, 657);
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(134)))), ((int)(((byte)(220)))));
            this.button2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(134)))), ((int)(((byte)(220)))));
            this.button2.BorderColor = System.Drawing.Color.Transparent;
            this.button2.BorderRadius = 1;
            this.button2.BorderSize = 0;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("KoPubWorld돋움체 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(372, 101);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.button2.Size = new System.Drawing.Size(122, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "불러오기";
            this.button2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Btn_LoadRecipe);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(134)))), ((int)(((byte)(220)))));
            this.button1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(134)))), ((int)(((byte)(220)))));
            this.button1.BorderColor = System.Drawing.Color.Transparent;
            this.button1.BorderRadius = 1;
            this.button1.BorderSize = 0;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("KoPubWorld돋움체 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(372, 152);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.button1.Size = new System.Drawing.Size(122, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "저장";
            this.button1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Btn_SaveRecipe);
            // 
            // panel_window
            // 
            this.panel_window.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(80)))));
            this.panel_window.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_window.Location = new System.Drawing.Point(0, 0);
            this.panel_window.Name = "panel_window";
            this.panel_window.Size = new System.Drawing.Size(506, 26);
            this.panel_window.TabIndex = 6;
            this.panel_window.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_window_MouseDown);
            this.panel_window.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_window_MouseMove);
            this.panel_window.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_window_MouseUp);
            // 
            // Form_Recipe
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(506, 713);
            this.ControlBox = false;
            this.Controls.Add(this.panel_window);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView_RecipeList);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("KoPubWorld돋움체 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Recipe";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "레시피";
            this.Load += new System.EventHandler(this.FrmRecipe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Vision.CustomControls.RJButton button1;
        private Vision.CustomControls.RJButton button2;
        private Vision.CustomControls.RJButton button3;
        private System.Windows.Forms.ListView listView_RecipeList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_window;
    }
}
namespace LynxOptimizer
{
    partial class MainPanel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPanel));
            version_label = new Label();
            panelDec = new Panel();
            panelTitle = new Panel();
            labelClose = new Label();
            label1 = new Label();
            labelMinimize = new Label();
            panelSidebar = new Panel();
            panelSidebarLine = new Panel();
            panelAccent = new Panel();
            lblNavHome = new Label();
            lblNavHelp = new Label();
            panelContent = new Panel();
            panelTitle.SuspendLayout();
            panelSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // version_label
            // 
            version_label.AutoSize = true;
            version_label.ForeColor = SystemColors.ButtonFace;
            version_label.Location = new Point(153, 8);
            version_label.Name = "version_label";
            version_label.Size = new Size(65, 15);
            version_label.TabIndex = 2;
            version_label.Text = "appversion";
            version_label.MouseDown += TitleBar_MouseDown;
            // 
            // panelDec
            // 
            panelDec.BackColor = Color.FromArgb(184, 184, 184);
            panelDec.Dock = DockStyle.Top;
            panelDec.Location = new Point(0, 32);
            panelDec.Name = "panelDec";
            panelDec.Size = new Size(672, 1);
            panelDec.TabIndex = 0;
            // 
            // panelTitle
            // 
            panelTitle.BackColor = Color.FromArgb(25, 25, 25);
            panelTitle.Controls.Add(labelClose);
            panelTitle.Controls.Add(label1);
            panelTitle.Controls.Add(labelMinimize);
            panelTitle.Controls.Add(version_label);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(0, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(672, 32);
            panelTitle.TabIndex = 1;
            panelTitle.MouseDown += TitleBar_MouseDown;
            // 
            // labelClose
            // 
            labelClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelClose.BackColor = Color.Transparent;
            labelClose.Cursor = Cursors.Hand;
            labelClose.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelClose.ForeColor = Color.White;
            labelClose.Location = new Point(639, 2);
            labelClose.Name = "labelClose";
            labelClose.Size = new Size(30, 30);
            labelClose.TabIndex = 4;
            labelClose.Text = "✕";
            labelClose.TextAlign = ContentAlignment.MiddleCenter;
            labelClose.Click += labelClose_Click;
            labelClose.MouseEnter += labelClose_MouseEnter;
            labelClose.MouseLeave += labelClose_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 5);
            label1.Name = "label1";
            label1.Size = new Size(135, 19);
            label1.TabIndex = 3;
            label1.Text = "Lynx Optimizer";
            label1.MouseDown += TitleBar_MouseDown;
            // 
            // labelMinimize
            // 
            labelMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelMinimize.BackColor = Color.Transparent;
            labelMinimize.Cursor = Cursors.Hand;
            labelMinimize.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMinimize.ForeColor = Color.White;
            labelMinimize.Location = new Point(603, 2);
            labelMinimize.Name = "labelMinimize";
            labelMinimize.Size = new Size(30, 30);
            labelMinimize.TabIndex = 3;
            labelMinimize.Text = "–";
            labelMinimize.TextAlign = ContentAlignment.MiddleCenter;
            labelMinimize.Click += labelMinimize_Click;
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(27, 27, 29);
            panelSidebar.Controls.Add(panelSidebarLine);
            panelSidebar.Controls.Add(panelAccent);
            panelSidebar.Controls.Add(lblNavHome);
            panelSidebar.Controls.Add(lblNavHelp);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 33);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(160, 429);
            panelSidebar.TabIndex = 3;
            // 
            // panelSidebarLine
            // 
            panelSidebarLine.BackColor = Color.FromArgb(58, 58, 61);
            panelSidebarLine.Dock = DockStyle.Right;
            panelSidebarLine.Location = new Point(159, 0);
            panelSidebarLine.Name = "panelSidebarLine";
            panelSidebarLine.Size = new Size(1, 429);
            panelSidebarLine.TabIndex = 0;
            // 
            // panelAccent
            // 
            panelAccent.BackColor = Color.FromArgb(220, 50, 50);
            panelAccent.Location = new Point(0, 8);
            panelAccent.Name = "panelAccent";
            panelAccent.Size = new Size(3, 22);
            panelAccent.TabIndex = 1;
            // 
            // lblNavHome
            // 
            lblNavHome.BackColor = Color.Transparent;
            lblNavHome.Cursor = Cursors.Hand;
            lblNavHome.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblNavHome.ForeColor = Color.FromArgb(160, 160, 165);
            lblNavHome.Location = new Point(0, 10);
            lblNavHome.Name = "lblNavHome";
            lblNavHome.Size = new Size(159, 22);
            lblNavHome.TabIndex = 2;
            lblNavHome.Text = "HOME";
            lblNavHome.TextAlign = ContentAlignment.MiddleCenter;
            lblNavHome.Click += Nav_Click;
            lblNavHome.MouseEnter += Nav_MouseEnter;
            lblNavHome.MouseLeave += Nav_MouseLeave;
            // 
            // lblNavHelp
            // 
            lblNavHelp.BackColor = Color.Transparent;
            lblNavHelp.Cursor = Cursors.Hand;
            lblNavHelp.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblNavHelp.ForeColor = Color.FromArgb(160, 160, 165);
            lblNavHelp.Location = new Point(0, 40);
            lblNavHelp.Name = "lblNavHelp";
            lblNavHelp.Size = new Size(159, 22);
            lblNavHelp.TabIndex = 7;
            lblNavHelp.Text = "HELP";
            lblNavHelp.TextAlign = ContentAlignment.MiddleCenter;
            lblNavHelp.Click += Nav_Click;
            lblNavHelp.MouseEnter += Nav_MouseEnter;
            lblNavHelp.MouseLeave += Nav_MouseLeave;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(30, 30, 32);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(160, 33);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(512, 429);
            panelContent.TabIndex = 4;
            // 
            // MainPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 32);
            ClientSize = new Size(672, 462);
            Controls.Add(panelContent);
            Controls.Add(panelSidebar);
            Controls.Add(panelDec);
            Controls.Add(panelTitle);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lynx Optimizer";
            Load += MainPanel_Load;
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
            panelSidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label version_label;
        private Panel panelDec;
        private Panel panelTitle;
        private Label label1;
        private Label labelClose;
        private Label labelMinimize;
        private Panel panelSidebar;
        private Panel panelSidebarLine;
        private Label lblNavHome;
        private Label lblNavHelp;
        private Panel panelAccent;
        private Panel panelContent;
    }
}

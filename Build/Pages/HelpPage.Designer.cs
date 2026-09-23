namespace LynxOptimizer.Pages
{
    partial class HelpPage
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            lblHelpTitle = new Label();
            lblHelpText = new Label();
            SuspendLayout();
            // 
            // lblHelpTitle
            // 
            lblHelpTitle.AutoSize = true;
            lblHelpTitle.Font = new Font("Consolas", 15F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblHelpTitle.ForeColor = Color.White;
            lblHelpTitle.Location = new Point(27, 32);
            lblHelpTitle.Name = "lblHelpTitle";
            lblHelpTitle.Size = new Size(54, 23);
            lblHelpTitle.TabIndex = 0;
            lblHelpTitle.Text = "HELP";
            // 
            // lblHelpText
            // 
            lblHelpText.AutoSize = true;
            lblHelpText.Font = new Font("Consolas", 8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblHelpText.ForeColor = Color.FromArgb(200, 200, 205);
            lblHelpText.Location = new Point(30, 75);
            lblHelpText.Name = "lblHelpText";
            lblHelpText.Size = new Size(73, 52);
            lblHelpText.TabIndex = 1;
            lblHelpText.Text = "Test Page 2\r\n\r\n- Text 1\r\n- Text 2";
            // 
            // HelpPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 32);
            Controls.Add(lblHelpTitle);
            Controls.Add(lblHelpText);
            Name = "HelpPage";
            Size = new Size(512, 429);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHelpTitle;
        private Label lblHelpText;
    }
}

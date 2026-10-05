namespace LynxOptimizer.Pages
{
    partial class HomePage
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
            lblHomeTitle = new Label();
            lblHelpText = new Label();
            SuspendLayout();
            // 
            // lblHomeTitle
            // 
            lblHomeTitle.AutoSize = true;
            lblHomeTitle.Font = new Font("Consolas", 15F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblHomeTitle.ForeColor = Color.White;
            lblHomeTitle.Location = new Point(27, 32);
            lblHomeTitle.Name = "lblHomeTitle";
            lblHomeTitle.Size = new Size(54, 23);
            lblHomeTitle.TabIndex = 0;
            lblHomeTitle.Text = "HOME";
            // 
            // lblHelpText
            // 
            lblHelpText.AutoSize = true;
            lblHelpText.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblHelpText.ForeColor = Color.FromArgb(200, 200, 205);
            lblHelpText.Location = new Point(30, 75);
            lblHelpText.Name = "lblHelpText";
            lblHelpText.Size = new Size(469, 28);
            lblHelpText.TabIndex = 2;
            lblHelpText.Text = "This is the first preview version of Lynx, and many \r\nfeatures are missing. We are working on our GUI and optimizations!\r\n";
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 32);
            Controls.Add(lblHelpText);
            Controls.Add(lblHomeTitle);
            Name = "HomePage";
            Size = new Size(512, 429);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHomeTitle;
        private Label lblHelpText;
    }
}

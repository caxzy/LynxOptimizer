using System.Diagnostics;

namespace LynxOptimizer.Pages
{
    public partial class HelpPage : UserControl
    {
        public HelpPage()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string discordurl = "https://discord.com/invite/JVEWR9CGk5";

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = discordurl,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot be opened: " + ex.Message);
            }
        }
    }
}

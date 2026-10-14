using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace LynxUi.Pages
{
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void DiscordButton_Click(object sender, RoutedEventArgs e)
        {
            OpenUrl("https://discord.com/invite/JVEWR9CGk5");
        }

        private void GitHubButton_Click(object sender, RoutedEventArgs e)
        {
            OpenUrl("https://github.com/caxzy/LynxOptimizer");
        }

        private void OpenUrl(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception)
            {
            }
        }
    }
}
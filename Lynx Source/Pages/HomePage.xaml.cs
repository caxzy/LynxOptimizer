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
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "https://discord.com/invite/JVEWR9CGk5",
                    UseShellExecute = true
                });
            }
            catch (Exception)
            {
            }
        }
        private void GitHubButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "https://github.com/caxzy/LynxOptimizer",
                    UseShellExecute = true
                });
            }
            catch (Exception)
            {
            }
        }
    }
}
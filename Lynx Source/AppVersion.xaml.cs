using System;
using System.Net.Http;
using System.Windows;

namespace LynxUi
{
    public partial class AppVersion : Window
    {
        private const string GitHubRAW = "https://raw.githubusercontent.com/caxzy/LynxOptimizer/refs/heads/main/appversion.txt";

        public AppVersion()
        {
            InitializeComponent();
            CheckLynxVersion();
        }

        private async void CheckLynxVersion()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string remoteVersion = await client.GetStringAsync(GitHubRAW);
                    remoteVersion = remoteVersion.Trim();

                    if (MainWindow.AppVersion.Equals(remoteVersion, StringComparison.OrdinalIgnoreCase))
                    {
                        DialogResult = true;
                        Close();
                    }
                    else
                    {
                        StatusText.Text = "Warning: Version does not match!\nAre you sure you want to run the program?";
                        ButtonsPanel.Visibility = Visibility.Visible;
                    }
                }
            }
            catch (Exception)
            {
                StatusText.Text = "Failed to connect to the network.\nDo you want to run the program anyway?";
                ButtonsPanel.Visibility = Visibility.Visible;
            }
        }

        private void YesButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }

        private void NoButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
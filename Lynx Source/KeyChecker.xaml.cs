using System;
using System.Net.Http;
using System.Windows;

namespace LynxUi
{
    public partial class KeyChecker : Window
    {
        private const string ExpectedKey = "AspectWashroomPupilCanopyAbridgeMustangBabiedRemoldWrongedWool"; //Do not change. Lynx authentication key.
        private const string ExpectedUrlKey = "https://raw.githubusercontent.com/caxzy/LynxOptimizer/refs/heads/main/keysum.txt";

        public KeyChecker()
        {
            InitializeComponent();
            KeySumChecker();
        }

        private async void KeySumChecker()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string remoteChecksum = await client.GetStringAsync(ExpectedUrlKey);
                    remoteChecksum = remoteChecksum.Trim();

                    if (ExpectedKey.Equals(remoteChecksum, StringComparison.OrdinalIgnoreCase))
                    {
                        DialogResult = true;
                        Close();
                    }
                    else
                    {
                        StatusText.Text = "Warning: Official Key does not match!\nAre you sure you want to run the program?";
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
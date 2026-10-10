using LynxUi.Pages;
using System.Configuration;
using System.Windows;
using System.Windows.Input;

namespace LynxUi
{
    public partial class MainWindow : Window
    {
        private const string AppVersion = "PREVIEW:0.215.4";
        public static bool IsDiscordRpcEnabled { get; private set; } = true;

        public MainWindow()
        {
            InitializeComponent();
            VersionText.Text = AppVersion;
            MainFrame.Navigate(new HomePage());
        }

        public static void SetDiscordRpcState(bool isEnabled)
        {
            IsDiscordRpcEnabled = isEnabled;
        }

        private void Header_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void NavigateHome_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new HomePage());
        }

        private void NavigateHelp_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new HelpPage());
        }

        private void NavigateSettings_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MinimizeApp_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void CloseApp_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
using System.Runtime.InteropServices;
using LynxOptimizer.Pages;

namespace LynxOptimizer
{
    public partial class MainPanel : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        private static readonly Color NavNormal = Color.FromArgb(160, 160, 165);
        private static readonly Color NavActive = Color.White;
        private static readonly Color CloseHover = Color.IndianRed;

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern nint SendMessage(nint hWnd, int msg, nint wParam, nint lParam);

        private readonly Dictionary<Label, Control> _pages;
        private Label? _activeNav;

        public MainPanel()
        {
            InitializeComponent();
            DoubleBuffered = true;

            version_label.Text = AppVersion.Current;

            _pages = new()
            {
                [lblNavHome] = AddPage(new HomePage()),
                [lblNavHelp] = AddPage(new HelpPage()),
            };

            SelectTab(lblNavHome);
        }

        private Control AddPage(Control page)
        {
            page.Dock = DockStyle.Fill;
            page.Visible = false;
            panelContent.Controls.Add(page);
            return page;
        }

        private void SelectTab(Label nav)
        {
            if (nav == _activeNav) return;

            if (_activeNav is not null)
            {
                _activeNav.ForeColor = NavNormal;
                _pages[_activeNav].Visible = false;
            }

            nav.ForeColor = NavActive;
            _pages[nav].Visible = true;
            panelAccent.Top = nav.Top; 
            _activeNav = nav;
        }

        private void MainPanel_Load(object sender, EventArgs e)
        {
            MessageBox.Show("This is a developer version. Many features are missing.", "Lynx Devbeta");
        }

        private void Nav_Click(object sender, EventArgs e)
        {
            if (sender is Label nav) SelectTab(nav);
        }

        private void Nav_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Label nav && nav != _activeNav) nav.ForeColor = NavActive;
        }

        private void Nav_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Label nav && nav != _activeNav) nav.ForeColor = NavNormal;
        }

        private void labelMinimize_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;
        private void labelClose_Click(object sender, EventArgs e) => Close();
        private void labelClose_MouseEnter(object sender, EventArgs e) => labelClose.ForeColor = CloseHover;
        private void labelClose_MouseLeave(object sender, EventArgs e) => labelClose.ForeColor = Color.White;

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
    }
}

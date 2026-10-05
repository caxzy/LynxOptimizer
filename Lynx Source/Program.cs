namespace LynxOptimizer
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainPanel());
        }
    }
}

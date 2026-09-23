using System.Reflection;

namespace LynxOptimizer
{
    internal static class AppVersion
    {
        public static string Current { get; } =
            Assembly.GetExecutingAssembly()
                .GetCustomAttribute<AssemblyInformationalVersionAttribute>()?
                .InformationalVersion.Split('+')[0] ?? "dev";
    }
}

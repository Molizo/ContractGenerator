using System.Reflection;

namespace ContractGenerator.Utilities
{
    public class AppInfo
    {
        public static string GetAppVersion()
        {
            return Assembly.GetExecutingAssembly().
            GetCustomAttribute<AssemblyInformationalVersionAttribute>().
            InformationalVersion;
        }
    }
}
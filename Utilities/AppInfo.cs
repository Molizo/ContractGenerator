using System.Reflection;

namespace ContractGenerator.Utilities;

public class AppInfo
{
    public static string GetAppVersion()
    {
        return Assembly.GetEntryAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>()
            .InformationalVersion;
    }
}
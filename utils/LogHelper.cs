using System.Runtime.InteropServices;

namespace Utils;

public static class LogHelper
{
    private static string _sourceName = ".Net Runtime";

    public static void Print(string message, System.Diagnostics.EventLogEntryType type = System.Diagnostics.EventLogEntryType.Information)
    {
        if (System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            System.Diagnostics.EventLog.WriteEntry(_sourceName, message, type);
        }
        else
        {
            throw new NotSupportedException("Not supported on this platform");
        }
    }
}

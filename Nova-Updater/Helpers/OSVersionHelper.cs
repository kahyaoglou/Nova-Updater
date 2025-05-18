using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nova_Updater.Helpers
{
    public static class OSVersionHelper
    {
        public static string GetWindowsVersion()
        {
            Version version = Environment.OSVersion.Version;

            if (version.Major == 10)
            {
                if (version.Build >= 22000)
                    return "Windows 11";
                else
                    return "Windows 10";
            }
            else if (version.Major == 6)
            {
                if (version.Minor == 3)
                    return "Windows 8.1";
                else if (version.Minor == 2)
                    return "Windows 8";
                else if (version.Minor == 1)
                    return "Windows 7";
                else
                    return $"Windows 6.{version.Minor} (unknown build {version.Build})";
            }
            else
            {
                return $"an older version of Windows (Version {version})";
            }
        }

    }
}

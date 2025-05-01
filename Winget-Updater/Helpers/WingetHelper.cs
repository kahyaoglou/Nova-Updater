using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Winget_Updater.Helpers
{
    public static class WingetHelper
    {
        public static List<string> GetUpgradableApps()
        {
            List<string> upgradableApps = new List<string>();

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo()
                {
                    FileName = "cmd.exe",
                    Arguments = "/c winget upgrade",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    StandardOutputEncoding = System.Text.Encoding.UTF8
                };

                Process process = new Process { StartInfo = psi };
                process.Start();

                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                string[] lines = output.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);

                bool startReading = false;

                foreach (string line in lines)
                {
                    string trimmedLine = line.Trim();

                    if (!startReading)
                    {
                        if (trimmedLine.StartsWith("---"))
                            startReading = true;

                        continue;
                    }

                    if (
                        trimmedLine.StartsWith("Name") ||
                        trimmedLine.Contains("require explicit targeting") ||
                        trimmedLine.Contains("cannot be determined") ||
                        trimmedLine.Contains("--include-unknown") ||
                        trimmedLine.Contains("upgrade available") ||
                        trimmedLine.Contains("upgrades available") ||
                        trimmedLine.Contains("package(s)") ||
                        trimmedLine.StartsWith("---") ||
                        string.IsNullOrWhiteSpace(trimmedLine)
                    )
                        continue;

                    string[] parts = trimmedLine.Split(new[] { "  " }, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length > 0)
                    {
                        upgradableApps.Add(parts[0].Trim());
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return upgradableApps;
        }
    }
}

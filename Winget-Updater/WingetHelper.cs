using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Winget_Updater
{
    public static class WingetHelper
    {
        public static void OpenForm(Form currentForm, Form newForm)
        {
            newForm.Show();
            currentForm.Hide();
        }

        public static List<string> GetInstalledApps()
        {
            List<string> installedApps = new List<string>();

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo()
                {
                    FileName = "cmd.exe",
                    Arguments = "/c winget list",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                Process process = new Process { StartInfo = psi };
                process.Start();

                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                string[] lines = output.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string line in lines.Skip(2)) // İlk iki satır başlık olabilir, atlıyoruz.
                {
                    string[] parts = line.Split(new[] { "  " }, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length > 0)
                    {
                        installedApps.Add(parts[0].Trim()); // İlk sütun uygulama adıdır
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return installedApps;
        }
    }
}

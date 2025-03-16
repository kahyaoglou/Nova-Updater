using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Winget_Updater
{
    public static class WingetUpdater
    {
        // Belirli bir uygulamayı güncellemek için
        public static void UpdateApp(string appName)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo()
                {
                    FileName = "cmd.exe",
                    Arguments = $"/k winget upgrade \"{appName}\" --accept-package-agreements --accept-source-agreements",
                    UseShellExecute = true,
                    CreateNoWindow = false
                };

                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Tüm uygulamaları güncellemek için
        public static void UpdateAllApps()
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo()
                {
                    FileName = "cmd.exe",
                    Arguments = "/k winget upgrade --all --accept-package-agreements --accept-source-agreements",
                    UseShellExecute = true,
                    CreateNoWindow = false
                };

                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

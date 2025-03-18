using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Winget_Updater.Manager
{
    public static class WingetManager
    {
        public static void UpdateAppOrAll(bool isUpdateAll, string? appName = null)
        {
            try
            {
                string arguments;

                if (isUpdateAll)
                {
                    arguments = "/k winget upgrade --all --accept-package-agreements --accept-source-agreements";
                }
                else if (!string.IsNullOrEmpty(appName))
                {
                    arguments = $"/k winget upgrade \"{appName}\" --accept-package-agreements --accept-source-agreements";
                }
                else
                {
                    MessageBox.Show("Uygulama adı geçerli değil.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ProcessStartInfo psi = new ProcessStartInfo()
                {
                    FileName = "cmd.exe",
                    Arguments = arguments,
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

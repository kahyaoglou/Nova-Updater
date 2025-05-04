using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nova_Updater.Manager
{
    public static class WingetManager
    {
        public static async Task UpdateAppOrAllAsync(bool isUpdateAll, string? appName = null)
        {
            try
            {
                string arguments = BuildArguments(isUpdateAll, appName);
                if (string.IsNullOrEmpty(arguments))
                {
                    MessageBox.Show("Uygulama adı geçerli değil.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Properties.Settings.Default.LastUpdateTime = DateTime.Now;
                Properties.Settings.Default.Save();

                await RunCommandAsync(arguments);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string BuildArguments(bool isUpdateAll, string? appName)
        {
            if (isUpdateAll)
            {
                return "/k winget upgrade --all --accept-package-agreements --accept-source-agreements";
            }
            else if (!string.IsNullOrEmpty(appName))
            {
                return $"/k winget upgrade \"{appName}\" --accept-package-agreements --accept-source-agreements";
            }

            return string.Empty;
        }

        private static async Task RunCommandAsync(string arguments)
        {
            await Task.Run(() =>
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = arguments,
                    UseShellExecute = true,
                    CreateNoWindow = false
                };

                Process.Start(psi);
            });
        }
    }
}
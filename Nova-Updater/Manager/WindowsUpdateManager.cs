using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using Nova_Updater.Forms;

namespace Nova_Updater.Manager
{
    public static class WindowsUpdateManager
    {
        [DllImport("user32.dll")]
        private static extern IntPtr SetForegroundWindow(IntPtr hWnd);

        public static void OpenWindowsUpdateSettings(Form form)
        {
            try
            {
                var process = Process.Start(new ProcessStartInfo
                {
                    FileName = "ms-settings:windowsupdate",
                    UseShellExecute = true
                });
                Thread.Sleep(5000);
                SendKeys.SendWait("{ENTER}");
                SetForegroundWindow(form.Handle);

                MessageBox.Show(
                    "Eğer güncelleme otomatik olarak başlamadıysa lütfen manuel olarak güncellemeleri kontrol edin.",
                    "Bilgilendirme",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Windows Update sekmesi açılamadı.", ex);
            }
        }
    }
}
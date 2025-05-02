using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winget_Updater.Manager
{
    public class MicrosoftStoreUpdateManager
    {
        [DllImport("user32.dll")]
        private static extern IntPtr SetForegroundWindow(IntPtr hWnd);
        public static void OpenStoreUpdates(Form form)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "ms-windows-store://downloadsandupdates",
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
                MessageBox.Show("Store güncellemeleri sayfası açılamadı: " + ex.Message);
            }
        }

    }
}

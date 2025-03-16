using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winget_Updater
{
    public partial class UpdateSelectedApp: Form
    {
        public UpdateSelectedApp()
        {
            InitializeComponent();
            LoadInstalledApps();
        }

        private void LoadInstalledApps()
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo()
                {
                    FileName = "cmd.exe",
                    Arguments = "/c winget list",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                Process process = new Process { StartInfo = psi };
                process.Start();

                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                // Çıktıyı satır satır işle
                string[] lines = output.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string line in lines.Skip(2)) // İlk iki satır başlık olabilir, atlıyoruz.
                {
                    string[] parts = line.Split(new[] { "  " }, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length > 0)
                    {
                        listBoxApps.Items.Add(parts[0].Trim()); // İlk sütun uygulama adıdır
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RunWingetUpdate(string appName)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo()
                {
                    FileName = "cmd.exe",
                    Arguments = $"/k winget upgrade \"{appName}\" --accept-package-agreements --accept-source-agreements",
                    RedirectStandardOutput = false,
                    RedirectStandardError = false,
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listBoxApps.SelectedItem != null)
            {
                string selectedApp = listBoxApps.SelectedItem.ToString();
                RunWingetUpdate(selectedApp);
            }
            else
            {
                MessageBox.Show("Lütfen bir uygulama seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

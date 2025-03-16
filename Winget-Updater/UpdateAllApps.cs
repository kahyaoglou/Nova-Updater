using System.Diagnostics;

namespace Winget_Updater
{
    public partial class UpdateAllApps : Form
    {
        public UpdateAllApps()
        {
            InitializeComponent();
        }


        private void RunWingetUpdate()
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo()
                {
                    FileName = "cmd.exe",
                    Arguments = "/k winget upgrade --all --accept-package-agreements --accept-source-agreements",
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
            RunWingetUpdate();
        }
    }
}

using System;
using System.Windows.Forms;
using Winget_Updater.Helpers;
using Winget_Updater.Manager;

namespace Winget_Updater
{
    public partial class UpdateSelectedApp : Form
    {
        public UpdateSelectedApp()
        {
            InitializeComponent();
            LoadInstalledApps();
        }

        private void LoadInstalledApps()
        {
            listBoxApps.Items.Clear();
            var apps = WingetHelper.GetInstalledApps();

            foreach (var app in apps)
            {
                listBoxApps.Items.Add(app);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listBoxApps.SelectedItem != null)
            {
                string? selectedApp = listBoxApps.SelectedItem.ToString();
                WingetManager.UpdateAppOrAll(false, selectedApp);

            }
            else
            {
                MessageBox.Show("Lütfen bir uygulama seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SliderHelper.OpenForm(this, new MainPage());
        }

        private void UpdateSelectedApp_Load(object sender, EventArgs e)
        {
            ThemeManager.ApplyTheme(this);
        }
    }
}

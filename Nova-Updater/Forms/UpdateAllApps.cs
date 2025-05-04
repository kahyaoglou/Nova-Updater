using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nova_Updater.Helpers;
using Nova_Updater.Manager;

namespace Nova_Updater.Forms
{
    public partial class UpdateAllApps : Form
    {
        public UpdateAllApps()
        {
            InitializeComponent();
        }

        private void btnUpdateAll_Click(object sender, EventArgs e)
        {
            WingetManager.UpdateAppOrAllAsync(true);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SliderHelper.OpenForm(this, new MainPage());
        }

        private void UpdateAllApps_Load(object sender, EventArgs e)
        {
            ThemeManager.ApplyTheme(this);
            DateTime lastUpdate = Properties.Settings.Default.LastUpdateTime;

            if (lastUpdate.Year < 2001)
            {
                lblLastUpdate.Text = "Henüz hiç güncelleme yapılmadı.";
            }
            else
            {
                TimeSpan difference = DateTime.Now - lastUpdate;
                lblLastUpdate.Text = $"Son güncelleme: {lastUpdate:g} ({difference.Days} gün önce)";
            }
        }
    }
}

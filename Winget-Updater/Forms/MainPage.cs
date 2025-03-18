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
using Winget_Updater.Forms;
using Winget_Updater.Helpers;
using Winget_Updater.Manager;

namespace Winget_Updater
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            ThemeManager.ApplyTheme(this);
        }

        private void btnUpdateAll_Click(object sender, EventArgs e)
        {
            SliderHelper.OpenForm(this, new UpdateAllApps());
        }

        private void btnUpdateSelected_Click(object sender, EventArgs e)
        {
            SliderHelper.OpenForm(this, new UpdateSelectedApp());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnToggleDarkMode_Click(object sender, EventArgs e)
        {
            ThemeManager.ToggleDarkMode();
            ThemeManager.ApplyTheme(this);
        }
    }
}

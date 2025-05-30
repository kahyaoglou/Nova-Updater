﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nova_Updater.Forms;
using Nova_Updater.Helpers;
using Nova_Updater.Manager;
using Winget_Updater.Manager;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Nova_Updater
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
            ThemeManager.UpdateLogo(pbxLogo, btnInfo);

            toolTipInfo.SetToolTip(btnInfo, "TR - Nova Updater, bilgisayarınızdaki uygulamaları güncel tutmanızı kolaylaştırır. Tek tıkla güncelleyin. Furkan Eralp Kahyaoğlu tarafından geliştirilmiştir.\n" +
                "EN - Nova Updater, makes it easy to keep the applications on your computer up to date. Update them with a single click. Developed by Furkan Eralp Kahyaoğlu.");

            string osVersion = OSVersionHelper.GetWindowsVersion();

            if (osVersion != "Windows 11")
            {
                btnMicrosoftStoreApps.Enabled = false;
                btnWindowsApps.Enabled = false;
                btnMicrosoftStoreApps.Text = btnMicrosoftStoreApps.Text + $" (Coming soon for {osVersion})";
                btnWindowsApps.Text = btnWindowsApps.Text + $" (Coming soon for {osVersion})";
            }
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
            ThemeManager.UpdateLogo(pbxLogo, btnInfo);
        }

        private void btnWindowsApps_Click(object sender, EventArgs e)
        {
            WindowsUpdateManager.OpenWindowsUpdateSettings(this);
        }

        private void btnMicrosoftStoreApps_Click(object sender, EventArgs e)
        {
            MicrosoftStoreUpdateManager.OpenStoreUpdates(this);
        }
    }
}

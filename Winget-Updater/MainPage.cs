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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnUpdateAll_Click(object sender, EventArgs e)
        {
            WingetUpdater.UpdateAllApps();
        }

        private void btnUpdateSelected_Click(object sender, EventArgs e)
        {
            UpdateSelectedApp updateSelectedApp = new UpdateSelectedApp();
            updateSelectedApp.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

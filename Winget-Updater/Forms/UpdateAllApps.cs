using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winget_Updater.Helpers;
using Winget_Updater.Manager;

namespace Winget_Updater.Forms
{
    public partial class UpdateAllApps : Form
    {
        public UpdateAllApps()
        {
            InitializeComponent();
        }

        private void btnUpdateAll_Click(object sender, EventArgs e)
        {
            WingetManager.UpdateAppOrAll(true);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SliderHelper.OpenForm(this, new MainPage());
        }
    }
}

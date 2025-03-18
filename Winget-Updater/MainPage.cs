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
            ApplyTheme();
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

        private void ApplyTheme()
        {
            if (Properties.Settings.Default.IsDarkMode)
            {
                this.BackColor = Color.FromArgb(30, 30, 30);
                this.ForeColor = Color.White;

                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is Button btn)
                    {
                        btn.BackColor = Color.FromArgb(50, 50, 50);
                        btn.ForeColor = Color.White;
                    }
                    else if (ctrl is TextBox txt)
                    {
                        txt.BackColor = Color.FromArgb(45, 45, 45);
                        txt.ForeColor = Color.White;
                    }
                    else if (ctrl is Label lbl)
                    {
                        lbl.ForeColor = Color.White;
                    }
                }
            }
            else
            {
                this.BackColor = SystemColors.Control;
                this.ForeColor = SystemColors.ControlText;

                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is Button btn)
                    {
                        btn.BackColor = SystemColors.Control;
                        btn.ForeColor = SystemColors.ControlText;
                    }
                    else if (ctrl is TextBox txt)
                    {
                        txt.BackColor = SystemColors.Window;
                        txt.ForeColor = SystemColors.WindowText;
                    }
                    else if (ctrl is Label lbl)
                    {
                        lbl.ForeColor = SystemColors.ControlText;
                    }
                }
            }
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            ThemeManager.ApplyTheme(this);
        }

        private void btnToggleDarkMode_Click(object sender, EventArgs e)
        {
            ThemeManager.ToggleDarkMode();
            ThemeManager.ApplyTheme(this);
        }
    }
}

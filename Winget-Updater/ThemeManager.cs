using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winget_Updater
{
    public static class ThemeManager
    {
        public static void ApplyTheme(Form form)
        {
            bool isDarkMode = Properties.Settings.Default.IsDarkMode;

            if (isDarkMode)
            {
                form.BackColor = Color.FromArgb(30, 30, 30);
                form.ForeColor = Color.White;

                foreach (Control ctrl in form.Controls)
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
                    else if (ctrl is Panel pnl)
                    {
                        pnl.BackColor = Color.FromArgb(40, 40, 40);
                    }
                }
            }
            else
            {
                form.BackColor = SystemColors.Control;
                form.ForeColor = SystemColors.ControlText;

                foreach (Control ctrl in form.Controls)
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
                    else if (ctrl is Panel pnl)
                    {
                        pnl.BackColor = SystemColors.Control;
                    }
                }
            }
        }

        public static void ToggleDarkMode()
        {
            Properties.Settings.Default.IsDarkMode = !Properties.Settings.Default.IsDarkMode;
            Properties.Settings.Default.Save();
        }
    }
}
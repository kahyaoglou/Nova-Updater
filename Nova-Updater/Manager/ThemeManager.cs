using System.Drawing;
using System.Windows.Forms;

namespace Nova_Updater.Manager
{
    public static class ThemeManager
    {
        public static void ApplyTheme(Form form)
        {
            bool isDark = Properties.Settings.Default.IsDarkMode;

            form.BackColor = isDark ? Color.FromArgb(30, 30, 30) : SystemColors.Control;
            form.ForeColor = isDark ? Color.White : SystemColors.ControlText;

            foreach (Control ctrl in form.Controls)
                ApplyThemeToControl(ctrl, isDark);
        }

        private static void ApplyThemeToControl(Control ctrl, bool isDark)
        {
            switch (ctrl)
            {
                case Button btn:
                    btn.BackColor = isDark ? Color.FromArgb(50, 50, 50) : SystemColors.Control;
                    btn.ForeColor = isDark ? Color.White : SystemColors.ControlText;
                    break;
                case TextBox txt:
                    txt.BackColor = isDark ? Color.FromArgb(45, 45, 45) : SystemColors.Window;
                    txt.ForeColor = isDark ? Color.White : SystemColors.WindowText;
                    break;
                case Label lbl:
                    lbl.ForeColor = isDark ? Color.White : SystemColors.ControlText;
                    break;
                case Panel pnl:
                    pnl.BackColor = isDark ? Color.FromArgb(40, 40, 40) : SystemColors.Control;
                    break;
            }
        }

        public static void ToggleDarkMode()
        {
            Properties.Settings.Default.IsDarkMode = !Properties.Settings.Default.IsDarkMode;
            Properties.Settings.Default.Save();
        }

        public static void UpdateLogo(PictureBox logo, PictureBox info)
        {
            bool isDark = Properties.Settings.Default.IsDarkMode;

            logo.Image = isDark ? Properties.Resources.nova_updater_beige : Properties.Resources.nova_updater_navy;
            info.Image = isDark ? Properties.Resources.info_beige : Properties.Resources.info_navy;

            logo.SizeMode = PictureBoxSizeMode.Zoom;
            info.SizeMode = PictureBoxSizeMode.Zoom;
        }

        public static void StyleLastUpdateLabel(Label label)
        {
            bool isDark = Properties.Settings.Default.IsDarkMode;
            Color foreColor = isDark ? Color.FromArgb(245, 245, 220) : Color.FromArgb(30, 51, 77);
            label.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            label.ForeColor = foreColor;
            label.BorderStyle = BorderStyle.None;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Padding = new Padding(4);
            label.AutoSize = false;
            label.Height = 30;
            label.Width = 350;
        }
    }
}

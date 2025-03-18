using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winget_Updater.Helpers
{
    public class SliderHelper
    {
        public static void OpenForm(Form currentForm, Form newForm)
        {
            newForm.Show();
            currentForm.Hide();
        }
    }
}

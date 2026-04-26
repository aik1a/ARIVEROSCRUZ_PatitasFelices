using System;
using System.Windows.Forms;
using RIVEROSCRUZ_PATITASFELICES.Views;

namespace RIVEROSCRUZ_PATITASFELICES
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }
    }
}

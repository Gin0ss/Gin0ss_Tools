using System;
using System.Windows.Forms;

namespace Vector_Maths_Tool
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Vector_Form());

        }
    }
}

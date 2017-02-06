using System;
using System.Windows.Forms;

namespace MVP_StopWatch
{
    static class Program
    {
        //entry point for the application.
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

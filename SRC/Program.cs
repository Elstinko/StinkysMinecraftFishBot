using System;
using System.Windows.Forms;

namespace FishBot2
{
    static class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FishBotForm1());
        }
    }
}

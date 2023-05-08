using System;
using System.Windows.Forms;

namespace Skovokh_Translator
{
    static class Program
    {
        [STAThread]
        static void Main ()
        {
            Application.SetHighDpiMode( HighDpiMode.SystemAware );
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault( false );
            Application.Run( new Form1() );
        }
    }
}

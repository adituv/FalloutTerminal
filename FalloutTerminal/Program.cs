using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CultureInfo = System.Globalization.CultureInfo;
using Thread = System.Threading.Thread;


namespace FalloutTerminal {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args) {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Length > 0 && args[0] == "--version") {
                MessageBox.Show(System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString());
            }
#if DEBUG
            if (args.Length > 1 && args[0] == "--use-culture") {
                try {
                    Thread.CurrentThread.CurrentCulture = new CultureInfo(args[1]);
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo(args[1]);
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
#endif
            Application.Run(new frmMain());
        }
    }
}

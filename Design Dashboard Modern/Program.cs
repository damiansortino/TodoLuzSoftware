using System;
using System.Windows.Forms;
using Design_Dashboard_Modern.Vistas;

namespace Design_Dashboard_Modern
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(new FrmLogin());
        }
    }
}

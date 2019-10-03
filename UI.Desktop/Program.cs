using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Desktop.Forms;

namespace UI.Desktop
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

            LoginFrm _LoginFrm = new LoginFrm();
            _LoginFrm.ShowDialog();

            if (_LoginFrm.DialogResult == DialogResult.OK)
                Application.Run(new PrincipalFrm());
        }
    }
}

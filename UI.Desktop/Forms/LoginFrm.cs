using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//libreria agregada para desarrollar la funcionalidad de arrastar el formulario.
using System.Runtime.InteropServices;
using Infra.CrossCutting;
using UI.Desktop.ApplicationController;



namespace UI.Desktop.Forms
{
    public partial class LoginFrm : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //creamos el controlador del login.
        private LoginController loginController;
        public LoginFrm()
        {
            InitializeComponent();
            loginController = new LoginController(this);

        }
        private void LoginFrm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }//fin de clase
}

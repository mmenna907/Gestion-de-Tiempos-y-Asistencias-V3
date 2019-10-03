using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Desktop.Forms;
using Aplication;
using System.Windows.Forms;
using System.Drawing;

namespace UI.Desktop.ApplicationController
{
    
    public class LoginController
    {
        LoginFrm loginFrm;
        public LoginController(LoginFrm pLoginFrm)
        {
            loginFrm = pLoginFrm;
            loginFrm.Load += new EventHandler(SetearValoresIniciales);
            //btnLogin
            loginFrm.btnLogin.Click += new EventHandler(btnLogin_Click);
            loginFrm.btnLogin.Enter += new EventHandler(btnLogin_Enter);
            loginFrm.btnLogin.Leave += new EventHandler(btnLogin_Leave);
            //TxtUsuario
            loginFrm.txtUsuario.Enter += new EventHandler(txtUsuario_Enter);
            loginFrm.txtUsuario.Leave += new EventHandler(txtUsuario_Leave);
            loginFrm.txtUsuario.KeyPress += new KeyPressEventHandler(txtUsuario_KeyPress);
            //txtContraseña
            loginFrm.txtContraseña.Enter += new EventHandler(txtContraseña_Enter);
            loginFrm.txtContraseña.Leave += new EventHandler(txtContraseña_Leave);
            loginFrm.txtContraseña.KeyPress += new KeyPressEventHandler(txtContraseña_KeyPress);
            //btnCerrar
            loginFrm.btnCerrar.Click += new EventHandler(btnCerrar_Click);
            //btnMinimizar
            loginFrm.btnMinimizar.Click += new EventHandler(btnMinimizar_Click);
        }

        private void SetearValoresIniciales(object sender, EventArgs e)
        {
            loginFrm.lblAccesoDenegado.Visible = false;
        }
        public void btnLogin_Click(object sender, EventArgs e)
        {
            if (loginFrm.txtUsuario.Text == "USUARIO" || loginFrm.txtUsuario.Text == "")
                MostrarMensaje("Ingrese un nombre de Usuario porfavor");
            else if (loginFrm.txtContraseña.Text == "CONTRASEÑA" || loginFrm.txtContraseña.Text == "")
                MostrarMensaje("Ingrese una contraseña porfavor");
            else
                Acceder();
        }
        private void btnLogin_Enter(object sender, EventArgs e)
        {
            loginFrm.btnLogin.BackColor = Color.FromArgb(64, 64, 64);
        }
        private void btnLogin_Leave(object sender, EventArgs e)
        {
            loginFrm.btnLogin.BackColor = Color.FromArgb(120, 120, 120);
        }
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (loginFrm.txtUsuario.Text == "USUARIO")
            {                
                loginFrm.txtUsuario.Text = "";
                loginFrm.txtUsuario.ForeColor = Color.White;
            }
        }
        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (loginFrm.txtUsuario.Text == "")
            {
                loginFrm.txtUsuario.Text = "USUARIO";
                loginFrm.txtUsuario.ForeColor = Color.Silver;
            }
        }
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
                loginFrm.txtContraseña.Focus();
        }
        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (loginFrm.txtContraseña.Text == "CONTRASEÑA")
            {
                loginFrm.txtContraseña.Text = "";
                loginFrm.txtContraseña.ForeColor = Color.White;
                loginFrm.txtContraseña.UseSystemPasswordChar = true;
            }
        }
        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (loginFrm.txtContraseña.Text == "")
            {
                loginFrm.txtContraseña.Text = "CONTRASEÑA";
                loginFrm.txtContraseña.ForeColor = Color.Silver;
                loginFrm.txtContraseña.UseSystemPasswordChar = false;
            }
        }
        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                loginFrm.btnLogin.BackColor = Color.FromArgb(64, 64, 64);
                btnLogin_Click(sender, e);//ejecuto el boton click
            }
        }
        private void Acceder()
        {
            string NombreUsuario = loginFrm.txtUsuario.Text.Trim();
            string contraseña = loginFrm.txtContraseña.Text.Trim();
            //valido las credenciales
            bool valido = new LogingService().Autenticar(NombreUsuario, contraseña);   
            if(valido)
            {
                var resultado = SesionService.Instancia.IniciarSesion(NombreUsuario);
                if(resultado=="")
                    loginFrm.DialogResult = DialogResult.OK;//ejecuto el formulario principal                
                else
                    MostrarMensaje(resultado);                
            }
            else
                MostrarMensaje("Acceso Denegado");
        }
        private void MostrarMensaje(string pMensaje)
        {
            loginFrm.lblAccesoDenegado.Text = pMensaje;
            loginFrm.lblAccesoDenegado.Visible = true;
            // PARA MOSTRAR EL MENSAJE CENTRADO
            // Obtengo el area actual
            Rectangle areaClienteFormulario = loginFrm.ClientRectangle;
            // Calculo el punto intermedio del área cliente.
            int puntoIntermedio = (areaClienteFormulario.Width / 2);
            // Calculo los nuevos puntos.
            int puntoX = (puntoIntermedio - (loginFrm.lblAccesoDenegado.Width / 2) + (loginFrm.panelLogo.Width / 2));//punto medio menos el ancho del texto a mostrar mas el ancho del panle logo
            int puntoY = loginFrm.lblAccesoDenegado.Location.Y;
            // Establecemos la nueva posición del control.
            loginFrm.lblAccesoDenegado.Location = new Point(puntoX, puntoY);
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            loginFrm.WindowState = FormWindowState.Minimized;
        }
    }
}

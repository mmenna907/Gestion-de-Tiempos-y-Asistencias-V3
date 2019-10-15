using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Desktop.Forms;
using Aplication;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Threading;

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
            loginFrm.btnLogin.Click += new EventHandler(BtnLogin_Click);
            loginFrm.btnLogin.Enter += new EventHandler(BtnLogin_Enter);
            loginFrm.btnLogin.Leave += new EventHandler(BtnLogin_Leave);
            //TxtUsuario
            loginFrm.txtUsuario.Enter += new EventHandler(TxtUsuario_Enter);
            loginFrm.txtUsuario.Leave += new EventHandler(TxtUsuario_Leave);
            loginFrm.txtUsuario.KeyPress += new KeyPressEventHandler(TxtUsuario_KeyPress);
            //txtContraseña
            loginFrm.txtContraseña.Enter += new EventHandler(TxtContraseña_Enter);
            loginFrm.txtContraseña.Leave += new EventHandler(TxtContraseña_Leave);
            loginFrm.txtContraseña.KeyPress += new KeyPressEventHandler(TxtContraseña_KeyPress);
            //btnCerrar
            loginFrm.btnCerrar.Click += new EventHandler(BtnCerrar_Click);
            //btnMinimizar
            loginFrm.btnMinimizar.Click += new EventHandler(BtnMinimizar_Click);
            //Mostrar Conexion con servidor de Autenticacion
            MostrarMensaje("Intentando establecer conexion", loginFrm.lblConexionConServidorDeAutenticacion);
            loginFrm.backgroundWorker1.DoWork += new DoWorkEventHandler(BackgroundWorker1_DoWork);
            loginFrm.backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(BackgroundWorker1_RunWorkerCompleted);
            loginFrm.backgroundWorker1.RunWorkerAsync();      
        }
        
        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        { //Ejecuta en segundo plano una conexion con el servidor de inicio de sesion.                   
            e.Result = new LogingService().ComprobarConexion();
        }
        
        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {//recibe el resultado cuando finaliza el metodo DoWork
            MostrarMensaje(e.Result.ToString(), loginFrm.lblConexionConServidorDeAutenticacion);
        }

        private void SetearValoresIniciales(object sender, EventArgs e)
        {
            loginFrm.lblAccesoDenegado.Visible = false;
        }
        public void BtnLogin_Click(object sender, EventArgs e)
        {
            if (loginFrm.txtUsuario.Text == "USUARIO" || loginFrm.txtUsuario.Text == "")
                MostrarMensaje("Ingrese un nombre de Usuario porfavor", loginFrm.lblAccesoDenegado);
            else if (loginFrm.txtContraseña.Text == "CONTRASEÑA" || loginFrm.txtContraseña.Text == "")
                MostrarMensaje("Ingrese una contraseña porfavor", loginFrm.lblAccesoDenegado);
            else
                Acceder();
        }
        private void BtnLogin_Enter(object sender, EventArgs e)
        {
            loginFrm.btnLogin.BackColor = Color.FromArgb(64, 64, 64);
        }
        private void BtnLogin_Leave(object sender, EventArgs e)
        {
            loginFrm.btnLogin.BackColor = Color.FromArgb(120, 120, 120);
        }
        private void TxtUsuario_Enter(object sender, EventArgs e)
        {
            if (loginFrm.txtUsuario.Text == "USUARIO")
            {                
                loginFrm.txtUsuario.Text = "";
                loginFrm.txtUsuario.ForeColor = Color.White;
            }
        }
        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            if (loginFrm.txtUsuario.Text == "")
            {
                loginFrm.txtUsuario.Text = "USUARIO";
                loginFrm.txtUsuario.ForeColor = Color.Silver;
            }
        }
        private void TxtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
                loginFrm.txtContraseña.Focus();
        }
        private void TxtContraseña_Enter(object sender, EventArgs e)
        {
            if (loginFrm.txtContraseña.Text == "CONTRASEÑA")
            {
                loginFrm.txtContraseña.Text = "";
                loginFrm.txtContraseña.ForeColor = Color.White;
                loginFrm.txtContraseña.UseSystemPasswordChar = true;
            }
        }
        private void TxtContraseña_Leave(object sender, EventArgs e)
        {
            if (loginFrm.txtContraseña.Text == "")
            {
                loginFrm.txtContraseña.Text = "CONTRASEÑA";
                loginFrm.txtContraseña.ForeColor = Color.Silver;
                loginFrm.txtContraseña.UseSystemPasswordChar = false;
            }
        }
        private void TxtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                loginFrm.btnLogin.BackColor = Color.FromArgb(64, 64, 64);
                BtnLogin_Click(sender, e);//ejecuto el boton click
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
                if (resultado == "")
                    loginFrm.DialogResult = DialogResult.OK;
                else
                    MostrarMensaje(resultado, loginFrm.lblAccesoDenegado);            
            }
            else
                MostrarMensaje("Acceso Denegado", loginFrm.lblAccesoDenegado);
        }
        private void MostrarMensaje(string pMensaje, Label pLabel)
        {
            pLabel.Text = pMensaje;
            pLabel.Visible = true;
            // PARA MOSTRAR EL MENSAJE CENTRADO
            // Obtengo el area actual
            Rectangle areaClienteFormulario = loginFrm.ClientRectangle;
            // Calculo el punto intermedio del área cliente.
            int puntoIntermedio = (areaClienteFormulario.Width / 2);
            // Calculo los nuevos puntos.
            int puntoX = (puntoIntermedio - (pLabel.Width / 2) + (loginFrm.panelLogo.Width / 2));//punto medio menos el ancho del texto a mostrar mas el ancho del panle logo
            int puntoY = pLabel.Location.Y;
            // Establecemos la nueva posición del control.
            pLabel.Location = new Point(puntoX, puntoY);
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            loginFrm.WindowState = FormWindowState.Minimized;
        }
    }
}

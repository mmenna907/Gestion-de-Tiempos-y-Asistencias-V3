using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Desktop.Forms;
using UI.Desktop.ViewModel;
using Domain.Model.ObjectValues;
using Aplication;

namespace UI.Desktop.ApplicationController
{
    public class PrincipalController
    {
        PrincipalFrm FormularioPrincipal;        
        int lx, ly, sw, sh;//para boton restaurar
        public PrincipalController(PrincipalFrm principalFrm)
        {
            FormularioPrincipal = principalFrm;
            DeshabilitarTodosLosBotones();
            HabilitarBotonesPermitidos();
            MostrarDatosSesion();            
            FormularioPrincipal.pictureMaximizar.Click +=new EventHandler(Maximizar);
            FormularioPrincipal.pictureMinimizar.Click += new EventHandler(Minimizar);
            FormularioPrincipal.pictureRestaurar.Click += new EventHandler(Restaurar);
            FormularioPrincipal.pictureCerrar.Click += new EventHandler(Cerrar);
        }
        private void DeshabilitarTodosLosBotones()
        {
            //Primero por defecto deshabilito todos los botones.
            FormularioPrincipal.btnEmpleados.Visible = false;
            FormularioPrincipal.btnDispositivos.Visible = false;
            FormularioPrincipal.btnUsuariosDelSistema.Visible = false;
            FormularioPrincipal.btnReportes.Visible = false;
        }
        private void HabilitarBotonesPermitidos()
        {            
            // Reviso los permisos que tiene el ususario en la base de datos y solo muestro los botones habiltados
            foreach (var item in SesionService.Instancia.ObtenerPermisosGenerales())
            {
                switch (item)
                {
                    case OpcDeFormularioPadre.EmpleadosFrm:
                        FormularioPrincipal.btnEmpleados.Visible = true;
                        FormularioPrincipal.btnEmpleados.Click += new EventHandler(AbrirFormulario);//Me suscribo a los eventos click de los botones del Formulario Principal
                        FormularioPrincipal.btnEmpleados.Tag = OpcDeFormularioPadre.EmpleadosFrm;
                        break;
                    case OpcDeFormularioPadre.DispositivosFrm:
                        FormularioPrincipal.btnDispositivos.Visible = true;
                        FormularioPrincipal.btnDispositivos.Click += new EventHandler(AbrirFormulario);
                        FormularioPrincipal.btnDispositivos.Tag = OpcDeFormularioPadre.DispositivosFrm;
                        break;
                    case OpcDeFormularioPadre.UsuariosDelSistemaFrm:
                        FormularioPrincipal.btnUsuariosDelSistema.Visible = true;
                        FormularioPrincipal.btnUsuariosDelSistema.Click += new EventHandler(AbrirFormulario);
                        FormularioPrincipal.btnUsuariosDelSistema.Tag = OpcDeFormularioPadre.UsuariosDelSistemaFrm;
                        break;
                    case OpcDeFormularioPadre.ReportesFrm:
                        FormularioPrincipal.btnReportes.Visible = true;
                        FormularioPrincipal.btnReportes.Click += new EventHandler(AbrirFormulario);
                        FormularioPrincipal.btnReportes.Tag = OpcDeFormularioPadre.ReportesFrm;
                        break;
                }
            }
        }
        private void MostrarDatosSesion()
        {
            FormularioPrincipal.btnUsuario.Text = SesionService.Instancia.ObtenerNombreUsuario();
        }
        private void Maximizar(object sender, EventArgs e)
        {
            lx = FormularioPrincipal.Location.X;
            ly = FormularioPrincipal.Location.Y;
            sw = FormularioPrincipal.Size.Width;
            sh = FormularioPrincipal.Size.Height;

            FormularioPrincipal.Size = Screen.PrimaryScreen.WorkingArea.Size;
            FormularioPrincipal.Location = Screen.PrimaryScreen.WorkingArea.Location;

            FormularioPrincipal.pictureMaximizar.Visible = false;
            FormularioPrincipal.pictureRestaurar.Visible = true;
        }
        private void Minimizar(object sender, EventArgs e)
        {
            FormularioPrincipal.WindowState = FormWindowState.Minimized;
        }
        private void Restaurar(object sender, EventArgs e)
        {
            FormularioPrincipal.Size = new Size(sw, sh);
            FormularioPrincipal.Location = new Point(lx, ly);

            FormularioPrincipal.pictureMaximizar.Visible = true;
            FormularioPrincipal.pictureRestaurar.Visible = false;
        }
        private void Cerrar(object sender, EventArgs e)
        {
            FormularioPrincipal.Close();
        }
        private void AbrirFormulario(object sender, EventArgs e)
        {
            //--------ABRO EL FORMULARIO SEGUN EL BOTON QUE SE PRESIONO-------------------------------------------------
            Button BotonPresionado = sender as Button;            
            switch (BotonPresionado.Tag)
            {
                case OpcDeFormularioPadre.EmpleadosFrm:
                    AbrirEnPanel<EmpleadosFrm>();                    
                    break;
                case OpcDeFormularioPadre.DispositivosFrm:
                    AbrirEnPanel<DispositivosFrm>();
                    break;
                //case OpcDeFormularioPadre.UsuariosDelSistemaFrm:
                //    AbrirEnPanel<UsuariosDelSistemaFrm>();
                //    break;
                //case OpcDeFormularioPadre.ReportesFrm:
                //    AbrirEnPanel<ReportesFrm>();
                //    break;
            }
            //Cambiamos el color de fondo del boton seleccionado para indicar que el formulario se encuentra abierto.
            BotonPresionado.BackColor = Color.FromArgb(100, 38, 0);
        }
        private void AbrirEnPanel<Forms>() where Forms : Form, new()
        {
            //-----------ABRO O MUESTRO EL FORMULARIO EN EL PANEL CENTRAL----------- 
            Form formAbrir = FormularioPrincipal.panelContenedor.Controls.OfType<Forms>().FirstOrDefault();

            //si el formulario/instancia no existe, creamos nueva instancia y mostramos
            if (formAbrir == null)
            {
                formAbrir = new Forms
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };
                FormularioPrincipal.panelContenedor.Controls.Add(formAbrir);
                FormularioPrincipal.panelContenedor.Tag = formAbrir;
                formAbrir.Show();
                formAbrir.BringToFront();
                formAbrir.FormClosed += new FormClosedEventHandler(SetButtonCloseForm);
            }
            else
            {
                //si la Formulario/instancia existe, lo traemos a frente
                formAbrir.BringToFront();

                //Si la instancia esta minimizada mostramos
                if (formAbrir.WindowState == FormWindowState.Minimized)
                    formAbrir.WindowState = FormWindowState.Normal;
            }
        }
        private void SetButtonCloseForm(object sender, FormClosedEventArgs e)
        {

            //Devuelvo el color original a los botones presionados porque el formulario se cerro.
            if (Application.OpenForms[OpcDeFormularioPadre.EmpleadosFrm.ToString()] == null)
                FormularioPrincipal.btnEmpleados.BackColor = Color.FromArgb(5, 70, 127);
            if (Application.OpenForms[OpcDeFormularioPadre.DispositivosFrm.ToString()] == null)
                FormularioPrincipal.btnDispositivos.BackColor = Color.FromArgb(5, 70, 127);
            if (Application.OpenForms[OpcDeFormularioPadre.UsuariosDelSistemaFrm.ToString()] == null)
                FormularioPrincipal.btnUsuario.BackColor = Color.FromArgb(5, 70, 127);
            if (Application.OpenForms[OpcDeFormularioPadre.ReportesFrm.ToString()] == null)
                FormularioPrincipal.btnReportes.BackColor = Color.FromArgb(5, 70, 127);
            //----------------DEVUELVO EL COLOR ORIGINAL A LOS BOTONES PORQUE EL FORMULARIO SE CERRO------------------------------
            //Form formularioCerrado = sender as Form;
            //switch(formularioCerrado.Text)
            //{
            //    case "EmpleadosFrm":
            //        FormularioPrincipal.btnEmpleados.BackColor = Color.FromArgb(5, 70, 127);
            //        break;
            //    case "DispositivosFrm":
            //        FormularioPrincipal.btnDispositivos.BackColor = Color.FromArgb(5, 70, 127);
            //        break;
            //    case "UsuariosDelSistemaFrm":
            //        FormularioPrincipal.btnUsuariosDelSistema.BackColor = Color.FromArgb(5, 70, 127);
            //        break;
            //    case "ReportesFrm":
            //        FormularioPrincipal.btnReportes.BackColor = Color.FromArgb(5, 70, 127);
            //        break;
            //}
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aplication;
using Aplication.Dto;
using UI.Desktop.ViewModel;
using UI.Desktop.Forms;


namespace UI.Desktop.ApplicationController
{
    public class EmpleadoController
    {
        EmpleadosFrm empleadosFrm;
        public EmpleadoController(EmpleadosFrm pempleadofrm)
        {
            empleadosFrm = pempleadofrm;
            DeshabilitarAgregarEditar();
            empleadosFrm.gridEmpleados.DataSource = GetAllEmpleados();
            empleadosFrm.btnModificar.Click += new EventHandler(HabilitarDeshabilitarAgregarEditar);
            empleadosFrm.btnAgregar.Click += new EventHandler(HabilitarDeshabilitarAgregarEditar);
            empleadosFrm.lblCancelarEdicion.Click += new EventHandler(HabilitarDeshabilitarAgregarEditar);
            empleadosFrm.picCerrar.Click += new EventHandler(Cerrar);
            empleadosFrm.txtBuscar.TextChanged += new EventHandler(TxtBuscar_TextChanged);
            empleadosFrm.txtBuscar.Enter += new EventHandler(TxtBuscar_Enter);
            empleadosFrm.txtBuscar.Leave += new EventHandler(TxtBuscar_Leave);
        }
        private List<EmpleadoViewModel> viewModelList;
        public IEnumerable<EmpleadoViewModel> GetAllEmpleados()
        {
            var empleadoDtoList = new EmpleadoService().GetEmpleados("");
            viewModelList = new List<EmpleadoViewModel>();

            foreach(EmpleadoDto item in empleadoDtoList)
            {
                viewModelList.Add(
                    new EmpleadoViewModel
                    {
                        Legajo = item.Legajo,
                        NombreEmpleado = item.NombreEmpleado,
                        TarjetaRFID = item.TarjetaRFID,
                        NombreSeccion = item.NombreSeccion
                    });
            }
            return viewModelList;
        }
        public object BuscarLocalmente(string filtro)
        {
            //Busca por Nombre y por Legajo.
            return viewModelList.FindAll(e=> e.NombreEmpleado.IndexOf(filtro, StringComparison.OrdinalIgnoreCase)>=0 || e.Legajo.ToString() == filtro );
        }
        private void DeshabilitarAgregarEditar()
        {
            empleadosFrm.panelLateral.Visible = false;
            //Animacion.Animate(empleadosFrm.panelLateral, Animacion.Effect.Slide, 200, 180);
        }
        private void HabilitarDeshabilitarAgregarEditar(object sender, EventArgs e)
        {
            //panelLateral.Visible = true;
            Animacion.Animate(empleadosFrm.panelLateral, Animacion.Effect.Slide, 200, 180);
        }
        private void Cerrar(object sender, EventArgs e)
        {
            empleadosFrm.Close();
        }
        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (empleadosFrm.txtBuscar.Text != "Buscar...")
                empleadosFrm.gridEmpleados.DataSource = BuscarLocalmente(empleadosFrm.txtBuscar.Text);
        }
        private void TxtBuscar_Enter(object sender, EventArgs e)
        {
            if (empleadosFrm.txtBuscar.Text == "Buscar...")
                empleadosFrm.txtBuscar.Text = "";
        }
        private void TxtBuscar_Leave(object sender, EventArgs e)
        {
            if (empleadosFrm.txtBuscar.Text == "")
            {
                empleadosFrm.txtBuscar.Text = "Buscar...";
            }
        }

    }
}

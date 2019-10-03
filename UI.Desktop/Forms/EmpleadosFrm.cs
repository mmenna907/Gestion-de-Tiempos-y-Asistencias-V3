using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Desktop.ApplicationController;

namespace UI.Desktop.Forms
{    
    public partial class EmpleadosFrm : Form
    {
        private EmpleadoController empleado;
        public EmpleadosFrm()
        {
            InitializeComponent();
            empleado = new EmpleadoController();
        }
        private void EmpleadoForm_Load(object sender, EventArgs e)
        {
            gridEmpleados.DataSource = empleado.GetAllEmpleados();
            DeshabilitarAgregarEditar();
        }
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            HabilitarAgregarEditar();
        }
        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "Buscar...")
                gridEmpleados.DataSource = empleado.BuscarLocalmente(txtBuscar.Text);
        }
        private void TxtBuscar_Enter(object sender, EventArgs e)
        {
            if(txtBuscar.Text == "Buscar...")
                txtBuscar.Text = "";
        }
        private void TxtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "Buscar...";
            }
        }
        private void DeshabilitarAgregarEditar()
        {
            panelLateral.Enabled = false;
        }
        private void HabilitarAgregarEditar()
        {
            //Habilito los campos a editar.
            panelLateral.Enabled = true;
        }
        private void PicCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void PicCancelarEdicion_Click(object sender, EventArgs e)
        {
            DeshabilitarAgregarEditar();
        }
    }
}

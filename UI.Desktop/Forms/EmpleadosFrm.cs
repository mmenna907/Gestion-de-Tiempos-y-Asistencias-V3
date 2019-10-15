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
            empleado = new EmpleadoController(this);
        }

    }
}

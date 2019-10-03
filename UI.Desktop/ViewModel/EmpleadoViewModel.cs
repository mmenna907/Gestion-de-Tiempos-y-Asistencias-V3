using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Desktop.ViewModel
{
    public class EmpleadoViewModel
    {
        //Validaciones
        public int Legajo { get; set; }
        public string NombreEmpleado { get; set; }
        public int TarjetaRFID { get; set; }
        //public int ContraseñaMarcacion { get; set; }
        public string NombreSeccion { get; set; }

        //public int FK_IDSeccion { get; set; }

    }
}

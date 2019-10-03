using Domain.Model.ObjectValues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Entities
{
    public class Empleado
    {
        public int IDEmpleado { get; set; }
        public int Legajo { get; set; }
        public string NombreEmpleado { get; set; }
        public int TarjetaRFID { get; set; }
        public int ContraseñaMarcacion { get; set; }
        public int FK_IDSeccion { get; set; }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Dto
{
    public class EmpleadoDto
    {
        public int IDEmpleado { get; set; }
        public int Legajo { get; set; }
        public string NombreEmpleado { get; set; }
        public int TarjetaRFID { get; set; }
        public int ContraseñaMarcacion { get; set; }
        public int IDSeccion { get; set; }
        public string NombreSeccion { get; set; }
    }
}

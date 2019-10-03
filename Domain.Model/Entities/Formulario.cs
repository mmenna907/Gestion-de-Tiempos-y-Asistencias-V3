using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model.ObjectValues;

namespace Domain.Model.Entities
{
    public class Formulario
    {
        public int idFormulario { get; set; }
        public string FormularioPadre { get; set; }
        public string FormularioHijo { get; set; }
    }
}

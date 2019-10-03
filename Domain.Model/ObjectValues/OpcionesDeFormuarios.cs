using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.ObjectValues
{
    //Para no utlizar un string y al cambiar el nombre de un formulario solo se deba cambiar aqui.
    public enum OpcDeFormularioPadre
    {
        EmpleadosFrm,
        DispositivosFrm,
        UsuariosDelSistemaFrm,
        ReportesFrm
    }
    public enum OpcDeFormularioHijo
    {
        ModificarEmpleadoFrm,
        EliminarEmpleadoFrm,
        etc
    }
}


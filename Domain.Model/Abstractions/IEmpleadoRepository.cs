using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model.Entities;

namespace Domain.Model.Abstractions 
{
    public interface IEmpleadoRepository : IGenericRepository<Empleado>
    {
        //el filtro puede ser el legajo o el nombre
        IEnumerable<Empleado> GetEmpleados(string filter);
    }
}

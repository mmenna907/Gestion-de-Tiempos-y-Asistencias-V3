using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model.Entities;

namespace Domain.Model.Abstractions
{
    public interface ISeccionRepository:IGenericRepository<Seccion>
    {
        //el filtro puede ser el id o el nombre
        IEnumerable<Seccion> GetSeccions(string filter);
        
    }
}

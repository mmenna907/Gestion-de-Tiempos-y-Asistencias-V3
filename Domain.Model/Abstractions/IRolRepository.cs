using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model.Entities;
using Domain.Model.ObjectValues;

namespace Domain.Model.Abstractions
{
    public interface IRolRepository : IGenericRepository<Rol>
    {
        //el filtro puede ser el id o el nombre
        IEnumerable<Rol> GetRols(string filter);
    }
}

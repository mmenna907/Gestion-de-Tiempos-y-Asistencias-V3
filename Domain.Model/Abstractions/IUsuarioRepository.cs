using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model.Entities;


namespace Domain.Model.Abstractions
{
    public interface IUsuarioRepository:IGenericRepository<Usuario>
    {
        //el filtro puede ser el id o el nombre
        IEnumerable<Usuario> GetUsuarios(string filter);
    }
}

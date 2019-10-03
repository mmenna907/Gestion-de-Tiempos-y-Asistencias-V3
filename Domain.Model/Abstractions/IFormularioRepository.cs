using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model.Entities;

namespace Domain.Model.Abstractions
{
    public interface IFormularioRepository: IGenericRepository<Formulario>
    {
        IEnumerable<Formulario> GetFormularios(string filter);
    }
}

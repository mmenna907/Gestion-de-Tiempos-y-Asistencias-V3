using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Abstractions
{
    public interface IGenericRepository<Entity> where Entity : class
    {
        int Add(Entity entidad);
        int Edit(Entity entidad);
        int Remove(int idPK);
    }
}

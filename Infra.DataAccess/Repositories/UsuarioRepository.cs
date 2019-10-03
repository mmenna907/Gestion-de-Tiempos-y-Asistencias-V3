using Domain.Model.Abstractions;
using Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DataAccess.Repositories
{
    public class UsuarioRepository : MasterRepository, IUsuarioRepository
    {
        private readonly string select;
        private readonly string insert;
        private readonly string update;
        private readonly string delete;

        public UsuarioRepository()
        {
            select = "GTA.ObtenerUsuarios";
            insert = "GTA.AgregarUsuario";
            update = "GTA.ModificarUsuario";
            delete = "GTA.EliminarUsuario";
        }
        public int Add(Usuario entidad)
        {
            parametros = new List<SqlParameter>
            {
                new SqlParameter("@IDUsuario", entidad.IdUsuario),
                new SqlParameter("@NombreUsuario", entidad.NombreUsuario)
            };
            return ExecuteNonQuery(insert);
        }

        public int Edit(Usuario entidad)
        {
            parametros = new List<SqlParameter>
            {
                new SqlParameter("@IDUsuario", entidad.IdUsuario),
                new SqlParameter("@NombreUsuario", entidad.NombreUsuario)
            };
            return ExecuteNonQuery(update);
        }
        public int Remove(int idPK)
        {
            parametros = new List<SqlParameter>
            {
                new SqlParameter("@IDUsuario", idPK)
            };
            return ExecuteNonQuery(delete);
        }

        public IEnumerable<Usuario> GetUsuarios(string filter)
        {
            parametros = new List<SqlParameter>
            {
                new SqlParameter("@Condicion", filter)
            };
            var tablaResultado = ExecuteReader(select);
            var listaUsuarios = new List<Usuario>();
            foreach (DataRow item in tablaResultado.Rows)
            {
                listaUsuarios.Add(new Usuario
                {
                    IdUsuario = Convert.ToInt32(item[0]),
                    NombreUsuario = Convert.ToString(item[1])              
                });
            }
            return listaUsuarios;        
        }
    }
}

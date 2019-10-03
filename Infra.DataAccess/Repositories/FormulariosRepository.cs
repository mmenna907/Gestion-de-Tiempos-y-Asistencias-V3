using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model.Abstractions;
using Domain.Model.Entities;
using Domain.Model.ObjectValues;

namespace Infra.DataAccess.Repositories
{
    public class FormularioRepository : MasterRepository, IFormularioRepository
    {
        private readonly string select;
        private readonly string insert;
        private readonly string update;
        private readonly string delete;

        public FormularioRepository()
        {
            select = "GTA.ObtenerFormularios";
            insert = "GTA.AgregarFormulario";
            update = "GTA.ModificarFormulario";
            delete = "GTA.EliminarFormulario";
        }
        public int Add(Formulario entidad)
        {
            parametros = new List<SqlParameter>
            {
                new SqlParameter("@NombreFormularioPadre", entidad.FormularioPadre),
                new SqlParameter("@NombreFormularioHijo", entidad.FormularioHijo)
            };
            return ExecuteNonQuery(insert);
        }
        public int Edit(Formulario entidad)
        {
            parametros = new List<SqlParameter>
            {
                new SqlParameter("@NombreFormularioPadre", entidad.FormularioPadre),
                new SqlParameter("@NombreFormularioHijo", entidad.FormularioHijo)
            };
            return ExecuteNonQuery(update);
        }
        public int Remove(int idPK)
        {
            parametros = new List<SqlParameter>
            {
                new SqlParameter("@IDFormulario", idPK)
            };
            return ExecuteNonQuery(delete);
        }
        public IEnumerable<Formulario> GetFormularios(string filter)
        {
            parametros = new List<SqlParameter>
            {
                new SqlParameter("@Condicion", filter)
            };
            var tablaResultado = ExecuteReader(select);
            var listaFormularios = new List<Formulario>();
            foreach (DataRow item in tablaResultado.Rows)
            {              
                listaFormularios.Add(new Formulario
                {
                    idFormulario = Convert.ToInt32(item["IDFormulario"]),
                    FormularioPadre = Convert.ToString(item["NombreFormularioPadre"]),
                    FormularioHijo = Convert.ToString(item["NombreFormularioHijo"])
                });
            }
            return listaFormularios;
        }
    }
}

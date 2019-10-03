using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model.Abstractions;
using Domain.Model.Entities;

namespace Infra.DataAccess.Repositories
{
    public class SeccionRepository : MasterRepository, ISeccionRepository
    {
        private readonly string select;
        private readonly string insert;
        private readonly string update;
        private readonly string delete;

        public SeccionRepository()
        {
            select = "GTA.ObtenerSecciones";
            insert = "GTA.AgregarSeccion";
            update = "GTA.ModificarSeccion";
            delete = "GTA.EliminarSeccion";
        }
        public int Add(Seccion entidad)
        {
            parametros = new List<SqlParameter>
            {
                new SqlParameter("@IDSeccion", entidad.IDSeccion),
                new SqlParameter("@NombreSeccion", entidad.NombreSeccion)
            };
            return ExecuteNonQuery(insert);

        }
        public int Edit(Seccion entidad)
        {
            parametros = new List<SqlParameter>
            {
                new SqlParameter("@NombreSeccion", entidad.NombreSeccion)
            };
            return ExecuteNonQuery(update);
        }
        public int Remove(int idPK)
        {
            parametros = new List<SqlParameter>
            {
                new SqlParameter("@IDSeccion", idPK)
            };
            return ExecuteNonQuery(delete);

        }
        public IEnumerable<Seccion> GetSeccions(string filter)
        {
            parametros = new List<SqlParameter>
            {
                new SqlParameter("@Condicion", filter)
            };
            var tablaResultado = ExecuteReader(select);
            var listaSecciones = new List<Seccion>();
            foreach (DataRow item in tablaResultado.Rows)
            {
                listaSecciones.Add(new Seccion
                {
                    IDSeccion = Convert.ToInt32(item["IDSeccion"]),
                    NombreSeccion = Convert.ToString(item["NombreSeccion"])
                });
            }
            return listaSecciones;
        }

        //public Seccion GetByEmpleado(string filter)
        //{
        //    parametros = new List<SqlParameter>
        //    {
        //        new SqlParameter("@Condicion", filter)
        //    };
        //    var tablaResultado = ExecuteReader(SelectByEmpelado);
        //    DataRow item = tablaResultado.Rows[0];
        //    Seccion seccion = new Seccion
        //    {
        //        IDSeccion = Convert.ToInt32(item["IDSeccion"]),
        //        NombreSeccion = Convert.ToString(item["NombreSeccion"])
        //    };
        //    return seccion;
        //}
    }
}

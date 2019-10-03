using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model.Entities;
using Domain.Model.Abstractions;
using System.Data;

namespace Infra.DataAccess.Repositories
{
    public class EmpleadoRepository : MasterRepository, IEmpleadoRepository
    {
        private readonly string select;
        private readonly string insert;
        private readonly string update;
        private readonly string delete;

        public EmpleadoRepository()
        {
            select = "GTA.ObtenerEmpleados";
            insert = "GTA.AgregarEmpleado";
            update = "GTA.ModificarEmpleado";
            delete = "GTA.EliminarEmpleado";
        }
        public int Add(Empleado entidad)
        {
            parametros = new List<SqlParameter>
            {
                new SqlParameter("@IDEmpleado", entidad.IDEmpleado),
                new SqlParameter("@Legajo", entidad.Legajo),
                new SqlParameter("@NombreEmpleado", entidad.NombreEmpleado),
                new SqlParameter("@TarjetaRFID", entidad.TarjetaRFID),
                new SqlParameter("@ContraseñaMarcacion", entidad.ContraseñaMarcacion),
                new SqlParameter("@FK_IDSeccion", entidad.FK_IDSeccion)
            };
            return ExecuteNonQuery(insert);

        }
        public int Edit(Empleado entidad)
        {
            parametros = new List<SqlParameter>
            {
                new SqlParameter("@Legajo", entidad.Legajo),
                new SqlParameter("@NombreEmpleado", entidad.NombreEmpleado),
                new SqlParameter("@TarjetaRFID", entidad.TarjetaRFID),
                new SqlParameter("@ContraseñaMarcacion", entidad.ContraseñaMarcacion),
                new SqlParameter("@FK_IDSeccion", entidad.FK_IDSeccion)
            };
            return ExecuteNonQuery(update);
        }
        public int Remove(int idPK)
        {
            parametros = new List<SqlParameter>
            {
                new SqlParameter("@IDEmpleado", idPK)
            };
            return ExecuteNonQuery(delete);

        }
        public IEnumerable<Empleado> GetEmpleados(string filter)
        {
            parametros = new List<SqlParameter>
            {
                new SqlParameter("@Condicion", filter)
            };
            var tablaResultado = ExecuteReader(select);
            var listaEmpleados = new List<Empleado>();
            foreach (DataRow item in tablaResultado.Rows)
            {
                listaEmpleados.Add(new Empleado
                {
                    IDEmpleado = Convert.ToInt32(item["IDEmpleado"]),
                    Legajo = Convert.ToInt32(item["Legajo"]),
                    NombreEmpleado = Convert.ToString(item["NombreEmpleado"]),
                    TarjetaRFID = Convert.ToInt32(item["TarjetaRFID"]),
                    ContraseñaMarcacion = Convert.ToInt32(item["ContraseñaMarcacion"]),
                    FK_IDSeccion = Convert.ToInt32(item["FK_IDSeccion"])
                });
            }
            return listaEmpleados;
        }
    }
}

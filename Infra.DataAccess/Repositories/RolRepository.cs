using Domain.Model.Abstractions;
using Domain.Model.Entities;
using Domain.Model.ObjectValues;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DataAccess.Repositories
{
    public class RolRepository : MasterRepository, IRolRepository
    {
        private readonly string select;
        private readonly string insert;
        private readonly string update;
        private readonly string delete;

        public RolRepository()
        {
            select = "GTA.ObtenerRoles";
            insert = "GTA.AgregarRol";
            update = "GTA.ModificarRol";
            delete = "GTA.EliminarRol";
        }

        public int Add(Rol entidad)
        {
            parametros = new List<SqlParameter>
            {
                new SqlParameter("@NombreRol", entidad.NombreRol)
            };
            return ExecuteNonQuery(insert);
        }

        public int Edit(Rol entidad)
        {
            parametros = new List<SqlParameter>
            {
                new SqlParameter("@NombreRol", entidad.NombreRol)
            };
            return ExecuteNonQuery(update);
        }
        public int Remove(int idPK)
        {
            parametros = new List<SqlParameter>
            {
                new SqlParameter("@IdRol", idPK)
            };
            return ExecuteNonQuery(delete);
        }

        public IEnumerable<Rol> GetRols(string filter)
        {
            parametros = new List<SqlParameter>
            {
                new SqlParameter("@Condicion", filter)
            };
            var tablaResultado = ExecuteReader(select);
            var listaRoles = new List<Rol>();
            foreach (DataRow item in tablaResultado.Rows)
            { //primero obtengo los roles del sistema               
                listaRoles.Add(new Rol
                {
                    IdRol = Convert.ToInt32(item["IdRol"]),
                    NombreRol = Convert.ToString(item["NombreRol"])
                });
            }
            return listaRoles;
        }
        //public Rol GetRol(string filter)
        //{
        //    parametros = new List<SqlParameter>
        //    {
        //        new SqlParameter("@Condicion", filter)
        //    };
        //    var tablaResultado = ExecuteReader(select);
        //    Rol rolbuscado = null;
        //    //primero obtengo el rol del sistema   
        //    foreach (DataRow item in tablaResultado.Rows)
        //   {             
        //        rolbuscado= new Rol
        //        {
        //            IdRol = Convert.ToInt32(item["IdRol"]),
        //            NombreRol = Convert.ToString(item["NobreRol"])
        //        };
        //    }
        //    var tablaResultado2 = ExecuteReader(selectFormularios);
        //    var listaFormularios = new List<FormStructure>();
        //    //segundo obtengo los formularios del sistema   
        //    foreach (DataRow item in tablaResultado2.Rows)
        //    {
        //        listaFormularios.Add(new FormStructure
        //        {
        //            IdFormulario = Convert.ToInt32(item["IDFormulario"]),
        //            FormularioPadre = Convert.ToString(item["NombreFormularioPadre"]),
        //            FormularioHijo = Convert.ToString(item["NombreFormularioHijo"])
        //        }); ;
        //    }
        //    return rolbuscado;
        //}

    }
}

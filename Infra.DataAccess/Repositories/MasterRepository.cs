using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DataAccess.Repositories
{
    public abstract class MasterRepository : Repository
    {
        protected List<SqlParameter> parametros;
        protected int ExecuteNonQuery(string transactSql)
        {
            //insertar, modificar y eliminar
            using (var conexion = GetConnection()) //using sirve para implementar la interfaz desechable dispose
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = transactSql;
                    comando.CommandType = CommandType.StoredProcedure;
                    foreach (SqlParameter item in parametros)
                    {
                        comando.Parameters.Add(item);
                    }
                    int resultado = comando.ExecuteNonQuery();
                    parametros.Clear();
                    return resultado;
                }
            }
        }
        protected DataTable ExecuteReader(string transactSql)
        {
            //Consultar
            using (var conexion = GetConnection()) //using sirve para implementar la interfaz desechable dispose
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = transactSql;
                    comando.CommandType = CommandType.StoredProcedure;
                    foreach (SqlParameter item in parametros)
                    {
                        comando.Parameters.Add(item);
                    }
                    SqlDataReader reader = comando.ExecuteReader();//podria haber utilizado using para liberar el readear pero luego se utiliza el dispose
                    using (var tabla = new DataTable())
                    {
                        tabla.Load(reader);
                        reader.Dispose();//Alternativa al comando using
                        parametros.Clear();
                        return tabla;
                    }
                }
            }
        }
    }
}

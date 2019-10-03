using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Infra.DataAccess.Repositories
{
    public abstract class Repository
    {
        //LA CADENA DE CONEXION SE ENCAPSULA EN ESTA CLASE Y SE CREA SOLO EN EL CONSTRUCTOR DEL OBJETO.
        private readonly string cadenaDeConexion;
        public Repository()
        {
            //La Cadena de conexion se encuentra en el archivo XML app.config
            cadenaDeConexion = ConfigurationManager.ConnectionStrings["ConiferalDB"].ToString();
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(cadenaDeConexion);
        }

    }
}

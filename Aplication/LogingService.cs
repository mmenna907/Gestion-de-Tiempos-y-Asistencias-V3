using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infra.CrossCutting;

namespace Aplication
{
    public class LogingService
    {
        public string ComprobarConexion()
        {
            Login login = new Login("", "");
            if (login.ComprobarPresenciaServidor())
                return "Conectado";
            return "No encuentro el servidor de autenticacion, no va a poder iniciar sesion";
        }
        public bool Autenticar(string pNombreUsuario, string contraseña)
        {
            Login login = new Login(pNombreUsuario, contraseña);
            return login.AutenticarUsuario();
        }
    }
}

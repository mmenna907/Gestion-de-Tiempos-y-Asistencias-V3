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
        public bool Autenticar(string pNombreUsuario, string contraseña)
        {
            Login login = new Login(pNombreUsuario, contraseña);
            return login.AutenticarUsuario();
        }
    }
}

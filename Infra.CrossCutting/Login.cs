using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;


namespace Infra.CrossCutting
{
    public class Login
    {
        private readonly string dominio;
        private readonly string NombreUsuarioCompleto;
        private readonly string contraseña;

        private readonly string path;

        public Login(string pUsuario, string pContraseña)
        {
            dominio = @"Coniferalsacif.local";
            NombreUsuarioCompleto = dominio + @"\" + pUsuario; //se completa el nombre de usuario
            contraseña = pContraseña;
            path = @"LDAP://srv-DC01";
        }
        public bool AutenticarUsuario()
        {
            //La clase DirectoryEntry encapsula un objeto en la jerarquía de Active Directory Domain Services.             
            DirectoryEntry de = new DirectoryEntry(path);
            try
            {
                de.AuthenticationType = AuthenticationTypes.Secure;
                de.Username = NombreUsuarioCompleto;
                de.Password = contraseña;
                object nativeObject = de.NativeObject;//este objeto es el que valida, si el usuario y contraseña son correctos, si no se va por el catch inmediatamente.                
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool ComprobarPresenciaServidor()
        {
            DirectoryEntry de = new DirectoryEntry(path);
            try
            {
                var test = de.Name; //test no hace nada pero en caso de no estar presente el servidor va a devolver una excepcion.
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}

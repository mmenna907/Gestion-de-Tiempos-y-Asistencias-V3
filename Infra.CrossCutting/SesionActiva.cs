using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model.Entities;

namespace Infra.CrossCutting
{
    public class SesionActiva
    {
        public DateTime HoraDeInicioDeSesion { get; set; }
        public DateTime HoraDeFinDeSesion { get; set; }
        public Usuario UsuarioActivo { get; set; }
        public List<string> OperacionesRealizadas { get; set; }

        public SesionActiva(Usuario pusuarioActivo)
        {
            UsuarioActivo = pusuarioActivo;
            HoraDeInicioDeSesion = DateTime.Today;
            OperacionesRealizadas = new List<string>();
        }
        public List<Formulario> GetPermisos()
        {
            return UsuarioActivo.RolDelUsuario.FormulariosHabilitados;
        }
    }
}

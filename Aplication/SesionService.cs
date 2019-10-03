using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infra.CrossCutting;
using Infra.DataAccess.Repositories;
using Domain.Model.Abstractions;
using Domain.Model.Entities;
using Domain.Model.ObjectValues;

namespace Aplication
{
    public class SesionService
    {
        public static readonly SesionService Instancia = new SesionService();
        private IUsuarioRepository usuarioRepository;
        private IRolRepository rolRepository;
        private IFormularioRepository formularioRepository;
        SesionActiva sesionActiva;
        private SesionService()
        {
            //El Servicio de Sesion implementa el patron singleton, ya que se mantiene activo durante todo el tiempo que este funcionando el programa y no deseamos que se creen varios objetos sesion.
            usuarioRepository = new UsuarioRepository();
            rolRepository = new RolRepository();
            formularioRepository = new FormularioRepository();
        }
        private Usuario GetUsuario(string filter)
        {
            //solicita a la capa de datos el nombre de usuario
            return usuarioRepository.GetUsuarios(filter).First();
        }
        private Rol GetRol(string filter)
        {
            //solicita a la capa de datos el rol que posee el usuario
            return rolRepository.GetRols(filter).First();
        }
        private List<Formulario> GetFormularios(string filter)
        {
            //solicita a la capa de datos los formularios disponibles para el usuario
            return formularioRepository.GetFormularios(filter).ToList();
        }
        public string IniciarSesion(string nombreUsuario)
        {
            string mensaje = "";
            try
            {
                Usuario usuarioSesion = GetUsuario(nombreUsuario);
                Rol rolSesion = GetRol(nombreUsuario);
                if (rolSesion != null)
                {
                    List<Formulario> formulariosSesion = GetFormularios(rolSesion.NombreRol);
                    if(formulariosSesion.Count==0)
                        return mensaje = "Sus credenciales estan ok."
                                    + "El usuario esta registrado en el sistema,\n"
                                    + "pero el rol asignado no posee formularios habilitados";//solo entraria por este caso si se creara el rol y no se le diera permiso
                    rolSesion.FormulariosHabilitados = formulariosSesion;
                    usuarioSesion.RolDelUsuario = rolSesion;
                }                
                sesionActiva = new SesionActiva(usuarioSesion);                
            }
            catch (Exception ex)
            {
                if (ex is System.InvalidOperationException)
                    return mensaje = "Sus credenciales estan ok,\n"
                                    +"pero no tiene permiso para usar este sistema";                
                else
                    return ex.ToString();
            }
            return mensaje;
        }
        public List<OpcDeFormularioPadre> ObtenerPermisosGenerales()
        {
            List<OpcDeFormularioPadre> listadoDeFormularios = new List<OpcDeFormularioPadre>();
            foreach (var item in sesionActiva.GetPermisos())
            {
                switch (item.FormularioPadre)
                {
                    case "EmpleadosFrm":
                        listadoDeFormularios.Add(OpcDeFormularioPadre.EmpleadosFrm);
                        break;
                    case "DispositivosFrm":
                        listadoDeFormularios.Add(OpcDeFormularioPadre.DispositivosFrm);
                        break;
                    case "UsuariosDelSistemaFrm":
                        listadoDeFormularios.Add(OpcDeFormularioPadre.UsuariosDelSistemaFrm);
                        break;
                    case "ReportesFrm":
                        listadoDeFormularios.Add(OpcDeFormularioPadre.ReportesFrm);
                        break;
                    default:
                        break;
                }
            }
            return listadoDeFormularios;
        }
        public List<OpcDeFormularioHijo> ObtenerPermisosParticulares()
        {
            List<OpcDeFormularioHijo> listadoDeFormulariosHijos = new List<OpcDeFormularioHijo>();
            foreach (var item in sesionActiva.GetPermisos())
            {
                switch (item.FormularioHijo)
                {
                    case "ModificarEmpleadoFrm":
                        listadoDeFormulariosHijos.Add(OpcDeFormularioHijo.ModificarEmpleadoFrm);
                        break;
                    case "EliminarEmpleadoFrm":
                        listadoDeFormulariosHijos.Add(OpcDeFormularioHijo.EliminarEmpleadoFrm);
                        break;
                    case "etc":
                        listadoDeFormulariosHijos.Add(OpcDeFormularioHijo.etc);
                        break;
                    default:
                        break;
                }
            }
            return listadoDeFormulariosHijos;
        }
        public string ObtenerNombreUsuario()
        {
            return sesionActiva.UsuarioActivo.NombreUsuario;
        }
    }
}

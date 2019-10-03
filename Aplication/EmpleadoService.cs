using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model.Abstractions;
using Domain.Model.Entities;
using Domain.Model.ObjectValues;
using Infra.DataAccess.Repositories;
using Aplication.Dto;


namespace Aplication
{
    public class EmpleadoService
    {
        readonly IEmpleadoRepository empleadoRepository;
        readonly ISeccionRepository seccionRepository;
        public EntityState EstadoEntidad { private get; set; }
        public EmpleadoService()
        {
            empleadoRepository = new EmpleadoRepository();
            seccionRepository = new SeccionRepository();
        }
        public IEnumerable<EmpleadoDto> GetEmpleados(string filter)
        {
            var empleadosList = empleadoRepository.GetEmpleados(filter);
            List<EmpleadoDto> empleadosDtoList = new List<EmpleadoDto>();
            List<Seccion> seccionList = seccionRepository.GetSeccions("") as List<Seccion>;
            foreach (Empleado item in empleadosList)
            {
                Seccion seccionBuscada = seccionList.Find(e => e.IDSeccion == item.FK_IDSeccion);
                empleadosDtoList.Add (new EmpleadoDto
                {
                    IDEmpleado = item.IDEmpleado,
                    Legajo = item.Legajo,
                    NombreEmpleado = item.NombreEmpleado,
                    TarjetaRFID = item.TarjetaRFID,
                    ContraseñaMarcacion = item.ContraseñaMarcacion,
                    IDSeccion = item.FK_IDSeccion,
                    NombreSeccion = seccionBuscada.NombreSeccion
                });                
            }
            return empleadosDtoList;
        }
        public string SaveChanges(EmpleadoDto empleadoDto)
        {            
            string mensaje = null;
            try
            {
                var empleadoDataModel = new Empleado
                {
                    IDEmpleado = empleadoDto.IDEmpleado,
                    Legajo = empleadoDto.Legajo,
                    NombreEmpleado = empleadoDto.NombreEmpleado,
                    TarjetaRFID = empleadoDto.TarjetaRFID,
                    ContraseñaMarcacion=empleadoDto.ContraseñaMarcacion,
                    FK_IDSeccion = empleadoDto.IDSeccion
                };

                switch (EstadoEntidad)
                {
                    case EntityState.Agregado:
                        //ejecutar reglas comerciales / calculos
                        empleadoRepository.Add(empleadoDataModel);
                        mensaje = "Se agrego correctamente";
                        break;
                    case EntityState.Modificado:
                        empleadoRepository.Edit(empleadoDataModel);
                        mensaje = "Se modifico correctamente";
                        break;
                    case EntityState.Eliminado:
                        empleadoRepository.Remove(empleadoDataModel.IDEmpleado);
                        mensaje = "Se elimino correctamente";
                        break;
                }
            }
            catch (Exception ex)
            {
                if (ex is System.Data.SqlClient.SqlException sqlEx && sqlEx.Number == 2627)
                    mensaje = "Registro Duplicado";
                else
                    mensaje = ex.ToString();
            }
            return mensaje;
        }

    }
}

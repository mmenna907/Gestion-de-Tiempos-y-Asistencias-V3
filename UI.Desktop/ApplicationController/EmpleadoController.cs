using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model.Entities;
using Aplication;
using UI.Desktop.ViewModel;
using Aplication.Dto;

namespace UI.Desktop.ApplicationController
{
    public class EmpleadoController
    {
        private List<EmpleadoViewModel> viewModelList;
        public IEnumerable<EmpleadoViewModel> GetAllEmpleados()
        {
            var empleadoDtoList = new EmpleadoService().GetEmpleados("");
            viewModelList = new List<EmpleadoViewModel>();

            foreach(EmpleadoDto item in empleadoDtoList)
            {
                viewModelList.Add(
                    new EmpleadoViewModel
                    {
                        Legajo = item.Legajo,
                        NombreEmpleado = item.NombreEmpleado,
                        TarjetaRFID = item.TarjetaRFID,
                        NombreSeccion = item.NombreSeccion
                    });
            }
            return viewModelList;
        }
        public object BuscarLocalmente(string filtro)
        {
            //Busca por Nombre y por Legajo.
            return viewModelList.FindAll(e=> e.NombreEmpleado.IndexOf(filtro, StringComparison.OrdinalIgnoreCase)>=0 || e.Legajo.ToString() == filtro );
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Entities
{
    public class Dispositivo
    {
        public int IdDispositivo { get; set; }
        public string NombreDispositivo { get; set; }
        public string ModeloDispositivo { get; set; }
        public long NumeroDeSerie { get; set; }
        public int NumeroDeIp { get; set; }
        public int NumeroDePuerto { get; set; }
        public int fkIdUbicacion { get; set; }
    }
    
}

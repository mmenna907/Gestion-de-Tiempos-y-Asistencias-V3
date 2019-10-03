﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model.ObjectValues;

namespace Domain.Model.Entities
{
    public class Rol
    {
        public int IdRol { get; set; }
        public string NombreRol { get; set; }
        public List<Formulario> FormulariosHabilitados { get; set; }      
        
    }
}

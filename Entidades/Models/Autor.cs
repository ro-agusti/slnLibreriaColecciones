﻿using Entidades.ModelsBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public class Autor:Persona 
    {
        #region constructor
        public Autor(int id, string apellido, string nombre, DateTime fechaNacimiento, string ciudad, string nacionalidad):base(id, apellido, nombre, fechaNacimiento, ciudad)
        {
            Nacionalidad = nacionalidad;
        }
        #endregion
        #region propiedades
        public string Nacionalidad { get; set; }
        #endregion
    }
}

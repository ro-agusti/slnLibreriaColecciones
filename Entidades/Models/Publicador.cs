using Entidades.ModelsBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public class Publicador: Persona
    {
        #region constructor
        public Publicador(int id, string apellido, string nombre, DateTime fechaNacimiento, string ciudad) : base(id, apellido, nombre, fechaNacimiento, ciudad)
        {
           
        }
        #endregion
       
    }
}

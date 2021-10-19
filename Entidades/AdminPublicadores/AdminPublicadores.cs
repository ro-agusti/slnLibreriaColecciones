using Entidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades.AdminPublicadores
{
    public static class AdminPublicadores
    {
        public static List<Publicador> listaDePublicadores = new List<Publicador>()
            {
            new Publicador(1,"Gomez", "Laura", new DateTime(1978,12,23), "Cordoba")
            };

        public static List<Publicador> listar()
        {
            return listaDePublicadores;
        }



        public static void insertar(int id, string apellido, string nombre, DateTime fechaNacimiento, string ciudad)
        {
            listaDePublicadores.Add(new Publicador(id, apellido, nombre, fechaNacimiento, ciudad));
        }

        public static void eliminar(int id)
        {
            bool publicadorExistente = false;
            int contador = 0;
            foreach (var item in listaDePublicadores)
            {

                if (id == item.ID)
                {
                    publicadorExistente = true;
                    break;
                }
                contador++;

            }
            if (publicadorExistente)
            {
                listaDePublicadores.RemoveAt(contador);

            }
        }
    }
}

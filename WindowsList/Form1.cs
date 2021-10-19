//using Entidades.Colecciones;
using Entidades.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsList
{
    public partial class Form1 : Form
    {
        List<Autor> autores = new List<Autor>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            autores.Add(new Autor(1, "Gomez", "Pedro", Convert.ToDateTime("30/12/1990"), "Mendoza", "Argentina"));
            autores.Add(new Autor(2, "Mauri", "Juana", Convert.ToDateTime("30/11/1997"), "Mendoza", "Argentina"));
            actualizarGrid();
        }

        private void selecionarPorCiudad()
        {
            List<Autor> ciudadesSelec = new List<Autor>();
            foreach (var item in autores)
            {
            string ciudadSelec = txtCiudadSeleccionada.Text;
                if (item.Ciudad == ciudadSelec)
                {   
                    
                    ciudadesSelec.Add(new Autor(item.ID, item.Apellido, item.Nombre, item.FechaNacimiento, item.Ciudad, item.Nacionalidad));
                    
                }
            }
            gridListaAutores.DataSource = null;
            gridListaAutores.DataSource = ciudadesSelec;
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int idAutor = Convert.ToInt32(txtID.Text);
            string apellidoAutor = txtApellido.Text;
            string nombreAutor = txtNombre.Text;
            DateTime fechaNacimientoAutor = Convert.ToDateTime(txtFechaNacimiento.Text);
            string ciudadAutor = txtCiudad.Text;
            string nacionalidadAutor = txtNacionalidad.Text;
            autores.Add(new Autor(idAutor, apellidoAutor, nombreAutor, fechaNacimientoAutor, ciudadAutor, nacionalidadAutor));
        }

        private void btnListarAutores_Click(object sender, EventArgs e)
        {
            actualizarGrid();
        }

        private void actualizarGrid()
        {
            gridListaAutores.DataSource = null;
            gridListaAutores.DataSource = autores;
        }

        private void btnTraerPorCiudad_Click(object sender, EventArgs e)
        {
            selecionarPorCiudad();
        }




        //private void btnGuardar_Click(object sender, EventArgs e)
        //{
        //   
        //    autores.
        //}
    }
}

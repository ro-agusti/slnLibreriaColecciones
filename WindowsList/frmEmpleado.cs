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
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();
        }
        List<Empleado> empleados = new List<Empleado>();
        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            empleados.Add(new Empleado(01, "Juarez", "Pedro", new DateTime(1975,03,25), "Cordoba", "Argentina"));
            empleados.Add(new Empleado(02, "Gomez", "Maria", new DateTime(1985, 08, 05), "Mendoza", "Argentina"));
            empleados.Add(new Empleado(03, "Lopez", "Juana", new DateTime(1996, 10, 13), "Cordoba", "Argentina"));
            actualizarGrd();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int idEmpleado = Convert.ToInt32(txtID.Text);
            string apellidoEmpleado = txtApellido.Text;
            string nombreEmpleado = txtNombre.Text;
            DateTime fechaNacimientoEmpleado = Convert.ToDateTime(txtFechaNacimiento.Text);
            string ciudadEmpleado = txtCiudad.Text;
            string nacionalidadEmpleado = txtNacionalidad.Text;
            empleados.Add(new Empleado(idEmpleado, apellidoEmpleado, nombreEmpleado, fechaNacimientoEmpleado, ciudadEmpleado, nacionalidadEmpleado));
            actualizarGrd();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idEmpleado = Convert.ToInt32(txtID.Text);
            bool empleadoExistente = false;
            int contador=0;
            foreach (var item in empleados)
            {
                
                if (idEmpleado == item.ID )
                {
                    empleadoExistente = true;
                    break;
                }
                contador++;
                
            }
            if (empleadoExistente)
            {
                empleados.RemoveAt(contador);
                actualizarGrd();
            }
            else
            {
                MessageBox.Show("ID incorrecto");
            }
        }

        private void btnTraerID_Click(object sender, EventArgs e)
        {
            
            foreach (var item in empleados)
            {
                int idEmpleado = Convert.ToInt32(txtID.Text);
                if (item.ID == idEmpleado)
                {
                    MessageBox.Show($"ID: {item.ID}\n Apellido: {item.Apellido}\nNombre: {item.Nombre}\nFecha de Nacimiento: {item.FechaNacimiento}\nCiudad: {item.Ciudad}\nNacionalidad: {item.Nacionalidad}");
                }
                else
                {
                    MessageBox.Show("ID incorrecto");
                }
            }
        }

        #region metodos utiles
        public void actualizarGrd()
        {
            gridPublicaciones.DataSource = null;
            gridPublicaciones.DataSource = empleados;
        }
        #endregion
    }
}

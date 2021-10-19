using Entidades.AdminPublicadores;
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
    public partial class frmPublicador : Form
    {
        public frmPublicador()
        {
            InitializeComponent();
        }
        private void frmPublicador_Load(object sender, EventArgs e)
        {
            actualizarGrid();
        }

        private void actualizarGrid()
        {
            gridPublicadores.DataSource = null;
            gridPublicadores.DataSource = AdminPublicadores.listar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int idPublicador = Convert.ToInt16(txtID.Text);
            string apellidoPublicador = txtApellido.Text;
            string nombrePublicador = txtNombre.Text;
            DateTime fechaNacimiento = Convert.ToDateTime(txtFechaNacimiento.Text);
            string ciudadPublicador = txtCiudad.Text;
            AdminPublicadores.insertar(idPublicador, apellidoPublicador, nombrePublicador, fechaNacimiento, ciudadPublicador);
            actualizarGrid();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            AdminPublicadores.eliminar(Convert.ToInt16(txtID.Text));
            actualizarGrid();
        }
    }
}

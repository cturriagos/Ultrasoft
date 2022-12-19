using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;
using System.Data.SqlClient;
using System.Data;

namespace CapaPresentacion
{
    public partial class MenuTrabajador : Form
    {
        public MenuTrabajador()
        {
            InitializeComponent();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Trabajador_Registro f1 = new Trabajador_Registro();
            f1.ShowDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Trabajador_Actualizar f2 = new Trabajador_Actualizar();
            f2.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Trabajador_Consulta f3 = new Trabajador_Consulta();
            f3.ShowDialog();
        }

        private void MenuTrabajador_Load(object sender, EventArgs e)
        {
            MostrarTrabajador();
        }

        private void MostrarTrabajador()
        {
            CNAgregarTrabajador conex = new CNAgregarTrabajador();
            dtgBusqueda.DataSource = conex.Mostrar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dtgBusqueda.Columns.Clear();
            MostrarTrabajador();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CNAgregarTrabajador conex = new CNAgregarTrabajador();
            string id;
            if (dtgBusqueda.SelectedRows.Count > 0)
            {
                id = dtgBusqueda.CurrentRow.Cells["Identificación"].Value.ToString();
                conex.eliminar(id);
                MostrarTrabajador();
                MessageBox.Show("Eliminado correctamente");
            }
            else
            {
                MessageBox.Show("Seleccione la fila por favor");
            }
        }
    }
}

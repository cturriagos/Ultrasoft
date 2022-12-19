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
    public partial class MenuCliente : Form
    {
        public MenuCliente()
        {
            InitializeComponent();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Cliente_Registro f1 = new Cliente_Registro();
            f1.ShowDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Cliente_Actualizar f2 = new Cliente_Actualizar();
            f2.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Cliente_Consulta f3 = new Cliente_Consulta();
            f3.ShowDialog();
        }

        private void MenuCliente_Load(object sender, EventArgs e)
        {
            MostrarClientes();
        }

        private void MostrarClientes()
        {
            CNAgregarCliente conex = new CNAgregarCliente();
            dtgBusqueda.DataSource = conex.Mostrar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dtgBusqueda.Columns.Clear();
            MostrarClientes();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CNAgregarCliente conex = new CNAgregarCliente();
            string id;
            if (dtgBusqueda.SelectedRows.Count > 0)
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Se eliminara el cliente y todos los registros del cliente. ¿Desea eliminar el cliente?","ELIMINAR CLIENTE",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if (opcion==DialogResult.OK)
                {
                    id = dtgBusqueda.CurrentRow.Cells["Identificación"].Value.ToString();
                    conex.eliminar(id);
                    MostrarClientes();
                    MessageBox.Show("Eliminado correctamente");
                }
            }
            else
            {
                MessageBox.Show("Seleccione la fila por favor");
            }
        }
    }
}

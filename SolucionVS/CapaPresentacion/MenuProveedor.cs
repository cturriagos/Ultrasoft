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
    public partial class MenuProveedor : Form
    {
        public MenuProveedor()
        {
            InitializeComponent();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Proveedor_Registro f1 = new Proveedor_Registro();
            f1.ShowDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Proveedor_Actualizar f2 = new Proveedor_Actualizar();
            f2.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Proveedor_Consulta f3 = new Proveedor_Consulta();
            f3.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dtgBusqueda.Columns.Clear();
            MostrarProveedor();
        }

        private void MenuProveedor_Load(object sender, EventArgs e)
        {
            MostrarProveedor();
        }

        private void MostrarProveedor()
        {
            CNAgregarProveedor conex = new CNAgregarProveedor();
            dtgBusqueda.DataSource = conex.Mostrar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CNAgregarProveedor conex = new CNAgregarProveedor();
            string id;
            if (dtgBusqueda.SelectedRows.Count > 0)
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Se eliminara el proveedor y todos los registros del proveedor. ¿Desea eliminar el proveedor?", "ELIMINAR PROVEEDOR", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    id = dtgBusqueda.CurrentRow.Cells["Identificación"].Value.ToString();
                    conex.eliminar(id);
                    MostrarProveedor();
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

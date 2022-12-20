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
    public partial class DatosDelComercial : Form
    {
        public DatosDelComercial()
        {
            InitializeComponent();
        }

        private void DatosDelComercial_Load(object sender, EventArgs e)
        {
            MostrarProveedor();
            MostrarComercial();
        }
        private void MostrarProveedor()
        {
            CNDueñoComercial conex = new CNDueñoComercial();
            dtgBusqueda.DataSource = conex.dueño();
        }

        private void MostrarComercial()
        {
            CNDueñoComercial conex = new CNDueñoComercial();
            dataGridView1.DataSource = conex.comercial();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            AgregarDueño f1 = new AgregarDueño();
            f1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MostrarProveedor();
            MostrarComercial();
        }

        private void btnRegistro_Click_1(object sender, EventArgs e)
        {
            AgregarDueño f1 = new AgregarDueño();
            f1.ShowDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarDueño f1 = new ActualizarDueño();
            f1.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CNDueñoComercial conex = new CNDueñoComercial();
            string id;
            if (dtgBusqueda.SelectedRows.Count > 0)
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Se eliminara el propietario y todos los registros del propietario. ¿Desea eliminar?", "ELIMINAR PROPIETARIO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            MostrarProveedor();
            MostrarComercial();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AgregarComercial f1 = new AgregarComercial();
            f1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActualizarComercial f1 = new ActualizarComercial();
            f1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CNDueñoComercial conex = new CNDueñoComercial();
            string id;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Se eliminara el comercial y todos los registros del comercial. ¿Desea eliminar?", "ELIMINAR COMERCIAL", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    id = dataGridView1.CurrentRow.Cells["Dirección"].Value.ToString();
                    conex.eliminar2(id);
                    MostrarComercial();
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

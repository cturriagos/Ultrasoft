using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmVentas : Form
    {
        private NCliente_Proveedor _NCliente_Proveedor;
        public frmVentas()
        {
            InitializeComponent();
            this._NCliente_Proveedor = new NCliente_Proveedor();
            dgvDatosCliente.ColumnHeadersDefaultCellStyle.Font = new Font(dgvDatosCliente.Font, FontStyle.Bold);
        }

        private void btnVerificaCliente_Click(object sender, EventArgs e)
        {
            MostrarCliente();
        }

        private void MostrarCliente()
        {
            this.dgvDatosCliente.DataSource = _NCliente_Proveedor.Mostrar(txtDniCliente.Text);
            dgvDatosCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            int n = dgvDatosCliente.ColumnCount;
            for (int i = 0; i < n; i++)
            {
                dgvDatosCliente.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }
        }

        private void cbxProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxProducto.Text == "Café")
            {
                txtPrecio.Text = "1,53";
                txtMetrica.Text = "libra (Lb)";
            }
            if (cbxProducto.Text == "Arroz")
            {
                txtPrecio.Text = "1,00";
                txtMetrica.Text = "Kilogramo (Kg)";
            }
            if (cbxProducto.Text == "Cacao")
            {
                txtPrecio.Text = "30,5";
                txtMetrica.Text = "Quintal (Q)";
            }
        }
    }
}

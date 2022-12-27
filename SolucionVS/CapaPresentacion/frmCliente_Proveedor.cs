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

namespace CapaPresentacion
{
    public partial class frmCliente_Proveedor : Form
    {
        public frmCliente_Proveedor()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void frmCliente_Proveedor_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            CNclienteProveedor conexion = new CNclienteProveedor();
            conexion.insertarClienteProveedor(cmbTipoIdentidaad.Text, txtIdentificacion.Text, txtRazonSocial.Text,
            txtNomComercial.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text, cmbTipoEntidad.Text);
            MessageBox.Show("se inserto correctamente");
        }
    }
}

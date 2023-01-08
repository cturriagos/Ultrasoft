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
        //CNclienteProveedor conexion = new CNclienteProveedor();
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
            mostrarDatos();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            
            //conexion.insertarClienteProveedor(cmbTipoIdentidaad.Text, txtIdentificacion.Text, txtRazonSocial.Text,
            //txtNomComercial.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text, cmbTipoEntidad.Text);
            MessageBox.Show("se inserto correctamente");
        }

        

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            
            string Rpta = "";
            Rpta = NCliente_Proveedor.insertarClienteProveedorN(cmbTipoIdentidaad.Text, txtIdentificacion.Text, txtRazonSocial.Text,
                txtNomComercial.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text, cmbTipoEntidad.Text);

            if (Rpta.Equals("OK"))
            {

                MessageBox.Show("Se insertó de forma correcta el registro");


            }
            else
            {
                //Mostramos el mensaje de error
                MessageBox.Show(Rpta);
            }
        }

        private void mostrarDatos()
        {
            this.dgvDatos.DataSource = NCliente_Proveedor.MostrarDatos();
        }


    }
}

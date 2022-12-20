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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            label4.Visible = false;
            label1.Visible = false;
            txtCodClientes.Visible = false;
            mostrarClienete.Visible = false;
            dtgbusqueda1.Visible = false;
            
            
        }

        private void btnClienteRegistro_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            txtCodClientes.Visible = false;
            mostrarClienete.Visible = false;
            MostrarClientes();
        }

        private void MostrarClientes()
        {
            label4.Visible = false;
            txtCodClientes.Visible = false;
            mostrarClienete.Visible = false;
            CNAgregarCliente conex = new CNAgregarCliente();
            dtgBusqueda.DataSource = conex.Mostrar();
        }

        private void btnTrabajadorRegistro_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            txtCodClientes.Visible = false;
            mostrarClienete.Visible = false;
            MostrarTrabajador();
            dtgBusqueda.Visible = true;
            dtgbusqueda1.Visible = false;
        }

        private void MostrarTrabajador()
        {
            label4.Visible = false;
            txtCodClientes.Visible = false;
            mostrarClienete.Visible = false;
            CNAgregarTrabajador conex = new CNAgregarTrabajador();
            dtgBusqueda.DataSource = conex.Mostrar();
            dtgBusqueda.Visible = true;
            dtgbusqueda1.Visible = false;
        }

        private void btnProveedorRegistro_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            txtCodClientes.Visible = false;
            mostrarClienete.Visible = false;
            MostrarProveedor();
            dtgBusqueda.Visible = true;
            dtgbusqueda1.Visible = false;
        }

        private void MostrarProveedor()
        {
            label4.Visible = false;
            txtCodClientes.Visible = false;
            mostrarClienete.Visible = false;
            CNAgregarProveedor conex = new CNAgregarProveedor();
            dtgBusqueda.DataSource = conex.Mostrar();
            dtgBusqueda.Visible = true;
            dtgbusqueda1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            txtCodClientes.Visible = false;
            mostrarClienete.Visible = false;
            COMPRAS();
            dtgBusqueda.Visible = true;
            dtgbusqueda1.Visible = false;
        }

        private void COMPRAS()
        {
            label4.Visible = false;
            txtCodClientes.Visible = false;
            mostrarClienete.Visible = false;
            CNRegistros conex = new CNRegistros();
            dtgBusqueda.DataSource = conex.MostrarCompras();
            dtgBusqueda.Visible = true;
            dtgbusqueda1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            txtCodClientes.Visible = false;
            mostrarClienete.Visible = false;
            ventas();
            dtgBusqueda.Visible = true;
            dtgbusqueda1.Visible = false;
        }

        private void ventas()
        {
            label4.Visible = false;
            txtCodClientes.Visible = false;
            mostrarClienete.Visible = false;
            CNRegistros conex = new CNRegistros();
            dtgBusqueda.DataSource = conex.MostrarVentas();
            dtgBusqueda.Visible = true;
            dtgbusqueda1.Visible = false;
        }

        private void btnBodegaRegistro_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            txtCodClientes.Visible = false;
            mostrarClienete.Visible = false;
            bodega();
            dtgBusqueda.Visible = true;
            dtgbusqueda1.Visible = false;
        }

        private void bodega()
        {

            label4.Visible = false;
            txtCodClientes.Visible = false;
            mostrarClienete.Visible = false;
            CNRegistros conex = new CNRegistros();
            dtgBusqueda.DataSource = conex.MostrarBodega();
            dtgBusqueda.Visible = true;
            dtgbusqueda1.Visible = false;
        }

        private void btnMostrarxCliente_Click(object sender, EventArgs e)
        {
           
            label4.Visible = true;
            txtCodClientes.Visible = true;
            mostrarClienete.Visible = true;
            dtgBusqueda.Visible = false;
            dtgbusqueda1.Visible = true;
           

            
        }

        private void mostrarClienete_Click(object sender, EventArgs e)
        {
            
                CNRegistros conex = new CNRegistros();
                
                dtgbusqueda1.DataSource = conex.dtoVentaCliente(Convert.ToInt32(txtCodClientes.Text));
                dtgbusqueda1.Columns[0].Width = 70;
                dtgbusqueda1.Columns[3].Width = 90;
                dtgbusqueda1.Columns[4].Width = 250;
            
        }

        private void txtCodClientes_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgbusqueda1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CapaNegocios;
using System.Data.SqlClient;
using System.Data;

namespace CapaPresentacion

{
    public partial class Cliente_Consulta : Form
    {
        public Cliente_Consulta()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Cliente_Consulta_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnverConsulta_Click(object sender, EventArgs e)
        {
            MostrarCliente();
        }

        private void MostrarCliente()
        {
            dtgBusqueda.Columns.Clear();
            VRFCliente cliente = new VRFCliente();
            SqlDataReader Loguear;
            cliente.cod = Convert.ToInt32(txtNombreClienteConsulta.Text);
            Loguear = cliente.Verificar();
            if (txtNombreClienteConsulta.Text != "")
            {
                if (Loguear.Read() == true)
                {
                    CNAgregarCliente conex = new CNAgregarCliente();
                    dtgBusqueda.DataSource = conex.MostrarClientes(Convert.ToInt32(txtNombreClienteConsulta.Text));
                }
                else
                {
                    MessageBox.Show("No existe registro del cliente");
                }
            }
            else
            {
                MessageBox.Show("Ingrese la DNI");
            }
        }

        private void Cliente_Consulta_Load(object sender, EventArgs e)
        {

        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

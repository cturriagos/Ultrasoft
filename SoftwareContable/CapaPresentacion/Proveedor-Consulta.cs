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
    public partial class Proveedor_Consulta : Form
    {
        public Proveedor_Consulta()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);

        private void btnverConsulta_Click(object sender, EventArgs e)
        {
            MostrarProveedor();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Proveedor_Consulta_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void MostrarProveedor()
        {
            dtgBusqueda.Columns.Clear();
            VRFProveedor proveedor = new VRFProveedor();
            SqlDataReader Loguear;
            proveedor.dni = txtNombreClienteConsulta.Text;
            Loguear = proveedor.Verificar();
            if (txtNombreClienteConsulta.Text != "")
            {
                if (Loguear.Read() == true)
                {
                    CNAgregarProveedor conex = new CNAgregarProveedor();
                    dtgBusqueda.DataSource = conex.MostrarProveedor(txtNombreClienteConsulta.Text);
                }
                else
                {
                    MessageBox.Show("No existe registro del proveedor");
                }
            }
            else
            {
                MessageBox.Show("Ingrese la DNI");
            }
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

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
    public partial class Proveedor_Registro : Form
    {
        public Proveedor_Registro()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);

        private void txtNombreProveedor_Enter(object sender, EventArgs e)
        {
            if (txtNombreProveedor.Text == "Nombre")
            {
                txtNombreProveedor.Text = "";
                txtNombreProveedor.ForeColor = Color.Black;
            }
        }

        private void txtNombreProveedor_Leave(object sender, EventArgs e)
        {
            if (txtNombreProveedor.Text == "")
            {
                txtNombreProveedor.Text = "Nombre";
                txtNombreProveedor.ForeColor = Color.Black;
            }
        }

        private void txtApellidoProveedor_Enter(object sender, EventArgs e)
        {
            if (txtApellidoProveedor.Text == "Apellido")
            {
                txtApellidoProveedor.Text = "";
                txtApellidoProveedor.ForeColor = Color.Black;
            }
        }

        private void txtApellidoProveedor_Leave(object sender, EventArgs e)
        {
            if (txtApellidoProveedor.Text == "")
            {
                txtApellidoProveedor.Text = "Apellido";
                txtApellidoProveedor.ForeColor = Color.Black;
            }
        }

        private void txtIdentificacionProveedor_Enter(object sender, EventArgs e)
        {
            if (txtIdentificacionProveedor.Text == "Identificación")
            {
                txtIdentificacionProveedor.Text = "";
                txtIdentificacionProveedor.ForeColor = Color.Black;
            }
        }

        private void txtIdentificacionProveedor_Leave(object sender, EventArgs e)
        {
            if (txtIdentificacionProveedor.Text == "")
            {
                txtIdentificacionProveedor.Text = "Identificación";
                txtIdentificacionProveedor.ForeColor = Color.Black;
            }
        }

        private void txtTelefonoProveedor_Enter(object sender, EventArgs e)
        {
            if (txtTelefonoProveedor.Text == "Teléfono")
            {
                txtTelefonoProveedor.Text = "";
                txtTelefonoProveedor.ForeColor = Color.Black;
            }
        }

        private void txtTelefonoProveedor_Leave(object sender, EventArgs e)
        {
            if (txtTelefonoProveedor.Text == "")
            {
                txtTelefonoProveedor.Text = "Teléfono";
                txtTelefonoProveedor.ForeColor = Color.Black;
            }
        }

        private void txtEmailProveedor_Enter(object sender, EventArgs e)
        {
            if (txtEmailProveedor.Text == "E-mail")
            {
                txtEmailProveedor.Text = "";
                txtEmailProveedor.ForeColor = Color.Black;
            }
        }

        private void txtEmailProveedor_Leave(object sender, EventArgs e)
        {
            if (txtEmailProveedor.Text == "")
            {
                txtEmailProveedor.Text = "E-mail";
                txtEmailProveedor.ForeColor = Color.Black;
            }
        }

        private void txtCodigoProveedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtDireccionCliente_Leave(object sender, EventArgs e)
        {
            if (txtDireccionCliente.Text == "")
            {
                txtDireccionCliente.Text = "Dirección Domicilio";
                txtDireccionCliente.ForeColor = Color.Black;
            }
        }

        private void txtDireccionCliente_Enter(object sender, EventArgs e)
        {
            if (txtDireccionCliente.Text == "Dirección Domicilio")
            {
                txtDireccionCliente.Text = "";
                txtDireccionCliente.ForeColor = Color.Black;
            }
        }

        private void Proveedor_Registro_Load(object sender, EventArgs e)
        {
            ListaDireccion();
        }

        private void ListaDireccion()
        {
            CNAgregarProveedor obj = new CNAgregarProveedor();
            comboBox2.DataSource = obj.Proveedor();
            comboBox2.DisplayMember = "direccion";
            comboBox2.ValueMember = "direccion";
            comboBox2.Text = "";
        }

        private void btnRegistrarProveedor_Click(object sender, EventArgs e)
        {

            if (txtNombreProveedor.Text != "")
            {
                if (txtApellidoProveedor.Text != "")
                {
                    if (comboBox1.Text != "")
                    {
                        if (txtIdentificacionProveedor.Text != "")
                        {
                            if (comboBox2.Text != "")
                            {
                                VRFProveedor proveedor = new VRFProveedor();
                                SqlDataReader Loguear;
                                proveedor.dni = txtIdentificacionProveedor.Text;
                                Loguear = proveedor.Verificar();
                                if (Loguear.Read() == true)
                                {
                                    MessageBox.Show("Ya existe otro proveedor con la misma DNI, verifique en la tabla de proveedor o diríjase a la parte buscar para buscar el proveedor");
                                }
                                else
                                {
                                    string fecha = "";
                                    CNAgregarProveedor conex = new CNAgregarProveedor();
                                    conex.insertarProveedor(dateTimePicker1.Text, txtNombreProveedor.Text, txtApellidoProveedor.Text, comboBox1.Text, txtIdentificacionProveedor.Text, txtTelefonoProveedor.Text, txtEmailProveedor.Text, txtDireccionCliente.Text, Convert.ToString(comboBox2.SelectedValue), fecha);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Seleccione una dirección de comercial");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingrese la DNI");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un tipo de identificación");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el apellido");
                }
            }
            else
            {
                MessageBox.Show("Ingrese el nombre");
            }
        }

        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {
            txtNombreProveedor.Text = "";
            txtNombreProveedor_Leave(null, e);
            txtApellidoProveedor.Text = "";
            txtApellidoProveedor_Leave(null, e);
            txtIdentificacionProveedor.Text = "";
            txtIdentificacionProveedor_Leave(null, e);
            txtTelefonoProveedor.Text = "";
            txtTelefonoProveedor_Leave(null, e);
            txtEmailProveedor.Text = "";
            txtEmailProveedor_Leave(null, e);
            txtDireccionCliente.Text = "";
            txtDireccionCliente_Leave(null, e);
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

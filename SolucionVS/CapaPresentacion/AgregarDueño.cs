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
    public partial class AgregarDueño : Form
    {
        public AgregarDueño()
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

        private void txtNombreCliente_Enter(object sender, EventArgs e)
        {
            if (txtNombreCliente.Text == "Nombre")
            {
                txtNombreCliente.Text = "";
                txtNombreCliente.ForeColor = Color.Black;
            }
        }

        private void txtNombreCliente_Leave(object sender, EventArgs e)
        {
            if (txtNombreCliente.Text == "")
            {
                txtNombreCliente.Text = "Nombre";
                txtNombreCliente.ForeColor = Color.Black;
            }
        }

        private void txtApellidoCliente_Enter(object sender, EventArgs e)
        {
            if (txtApellidoCliente.Text == "Apellido")
            {
                txtApellidoCliente.Text = "";
                txtApellidoCliente.ForeColor = Color.Black;
            }
        }

        private void txtApellidoCliente_Leave(object sender, EventArgs e)
        {
            if (txtApellidoCliente.Text == "")
            {
                txtApellidoCliente.Text = "Apellido";
                txtApellidoCliente.ForeColor = Color.Black;

            }
        }

        private void txtIdentificacionCliente_Enter(object sender, EventArgs e)
        {
            if (txtIdentificacionCliente.Text == "Identificación")
            {
                txtIdentificacionCliente.Text = "";
                txtIdentificacionCliente.ForeColor = Color.Black;
            }
        }

        private void txtIdentificacionCliente_Leave(object sender, EventArgs e)
        {
            if (txtIdentificacionCliente.Text == "")
            {
                txtIdentificacionCliente.Text = "Identificación";
                txtIdentificacionCliente.ForeColor = Color.Black;

            }
        }

        private void txtTelefonoCliente_Enter(object sender, EventArgs e)
        {
            if (txtTelefonoCliente.Text == "Teléfono")
            {
                txtTelefonoCliente.Text = "";
                txtTelefonoCliente.ForeColor = Color.Black;
            }
        }

        private void txtTelefonoCliente_Leave(object sender, EventArgs e)
        {
            if (txtTelefonoCliente.Text == "")
            {
                txtTelefonoCliente.Text = "Teléfono";
                txtTelefonoCliente.ForeColor = Color.Black;

            }
        }

        private void txtEmailCliente_Enter(object sender, EventArgs e)
        {
            if (txtEmailCliente.Text == "E-mail")
            {
                txtEmailCliente.Text = "";
                txtEmailCliente.ForeColor = Color.Black;
            }
        }

        private void txtEmailCliente_Leave(object sender, EventArgs e)
        {
            if (txtEmailCliente.Text == "")
            {
                txtEmailCliente.Text = "E-mail";
                txtEmailCliente.ForeColor = Color.Black;
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

        private void txtDireccionCliente_Leave(object sender, EventArgs e)
        {
            if (txtDireccionCliente.Text == "")
            {
                txtDireccionCliente.Text = "Dirección Domicilio";
                txtDireccionCliente.ForeColor = Color.Black;

            }
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            txtNombreCliente.Text = "";
            txtNombreCliente_Leave(null, e);
            txtApellidoCliente.Text = "";
            txtApellidoCliente_Leave(null, e);
            txtIdentificacionCliente.Text = "";
            txtIdentificacionCliente_Leave(null, e);
            txtTelefonoCliente.Text = "";
            txtTelefonoCliente_Leave(null, e);
            txtEmailCliente.Text = "";
            txtEmailCliente_Leave(null, e);
            txtDireccionCliente.Text = "";
            txtDireccionCliente_Leave(null, e);
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            if (txtNombreCliente.Text != "")
            {
                if (txtApellidoCliente.Text != "")
                {
                    if (comboBox1.Text != "")
                    {
                        if (txtIdentificacionCliente.Text != "")
                        {
                            VerificarDueño dueño = new VerificarDueño();
                            SqlDataReader Loguear;
                            dueño.dni = txtIdentificacionCliente.Text;
                            Loguear = dueño.Verificar();
                            if (Loguear.Read() == true)
                            {
                                MessageBox.Show("Ya existe otro propietario con la misma DNI, verifique en la tabla de propietarios");
                            }
                            else
                            {
                                CNDueñoComercial conex = new CNDueñoComercial();
                                conex.Insertardueño(txtNombreCliente.Text, txtApellidoCliente.Text, comboBox1.Text, txtIdentificacionCliente.Text, txtEmailCliente.Text, txtTelefonoCliente.Text,  txtDireccionCliente.Text);
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

        private void AgregarDueño_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

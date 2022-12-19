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
    public partial class Trabajador_Registro : Form
    {
        public Trabajador_Registro()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);

        private void Trabajador_Registro_Load(object sender, EventArgs e)
        {
            ListaDireccion();
        }

        private void txtNombreTrabajador_Enter(object sender, EventArgs e)
        {
            if (txtNombreTrabajador.Text == "Nombre")
            {
                txtNombreTrabajador.Text = "";
                txtNombreTrabajador.ForeColor = Color.Black;
            }
        }

        private void txtNombreTrabajador_Leave(object sender, EventArgs e)
        {
            if (txtNombreTrabajador.Text == "")
            {
                txtNombreTrabajador.Text = "Nombre";
                txtNombreTrabajador.ForeColor = Color.Black;

            }
        }

        private void txtApellidoTrabajador_Enter(object sender, EventArgs e)
        {
            if (txtApellidoTrabajador.Text == "Apellido")
            {
                txtApellidoTrabajador.Text = "";
                txtApellidoTrabajador.ForeColor = Color.Black;
            }
        }

        private void txtApellidoTrabajador_Leave(object sender, EventArgs e)
        {
            if (txtApellidoTrabajador.Text == "")
            {
                txtApellidoTrabajador.Text = "Apellido";
                txtApellidoTrabajador.ForeColor = Color.Black;

            }
        }

        private void txtIdentificacionTrabajador_Enter(object sender, EventArgs e)
        {
            if (txtIdentificacionTrabajador.Text == "Identificación")
            {
                txtIdentificacionTrabajador.Text = "";
                txtIdentificacionTrabajador.ForeColor = Color.Black;
            }
        }

        private void txtIdentificacionTrabajador_Leave(object sender, EventArgs e)
        {
            if (txtIdentificacionTrabajador.Text == "")
            {
                txtIdentificacionTrabajador.Text = "Identificación";
                txtIdentificacionTrabajador.ForeColor = Color.Black;

            }
        }

        private void txtTelefonoTrabajador_Enter(object sender, EventArgs e)
        {
            if (txtTelefonoTrabajador.Text == "Teléfono")
            {
                txtTelefonoTrabajador.Text = "";
                txtTelefonoTrabajador.ForeColor = Color.Black;
            }
        }

        private void txtTelefonoTrabajador_Leave(object sender, EventArgs e)
        {
            if (txtTelefonoTrabajador.Text == "")
            {
                txtTelefonoTrabajador.Text = "Teléfono";
                txtTelefonoTrabajador.ForeColor = Color.Black;

            }
        }

        private void txtEmailTrabajador_Enter(object sender, EventArgs e)
        {
            if (txtEmailTrabajador.Text == "E-mail")
            {
                txtEmailTrabajador.Text = "";
                txtEmailTrabajador.ForeColor = Color.Black;
            }
        }

        private void txtEmailTrabajador_Leave(object sender, EventArgs e)
        {
            if (txtEmailTrabajador.Text == "")
            {
                txtEmailTrabajador.Text = "E-mail";
                txtEmailTrabajador.ForeColor = Color.Black;

            }
        }

        private void ListaDireccion()
        {
            CNAgregarTrabajador obj = new CNAgregarTrabajador();
            comboBox2.DataSource = obj.trabajador();
            comboBox2.DisplayMember = "direccion";
            comboBox2.ValueMember = "direccion";
        }

        private void txtDireccionTrabajador_Enter(object sender, EventArgs e)
        {
            if (txtDireccionTrabajador.Text == "Dirección Domicilio")
            {
                txtDireccionTrabajador.Text = "";
                txtDireccionTrabajador.ForeColor = Color.Black;
            }
        }

        private void txtDireccionTrabajador_Leave(object sender, EventArgs e)
        {
            if (txtDireccionTrabajador.Text == "")
            {
                txtDireccionTrabajador.Text = "Dirección Domicilio";
                txtDireccionTrabajador.ForeColor = Color.Black;

            }
        }

        private void txtCodigoTrabajador_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrarTrabajador_Click(object sender, EventArgs e)
        {
            if (txtNombreTrabajador.Text != "")
            {
                if (txtApellidoTrabajador.Text != "")
                {
                    if (comboBox1.Text != "")
                    {
                        if (txtIdentificacionTrabajador.Text != "")
                        {
                            if (comboBox2.Text != "")
                            {
                                CNVRFTrabajador trabajador = new CNVRFTrabajador();
                                SqlDataReader Loguear;
                                trabajador.dni = txtIdentificacionTrabajador.Text;
                                Loguear = trabajador.Verificar();
                                if (Loguear.Read() == true)
                                {
                                    MessageBox.Show("Ya existe otro trabajador con la misma DNI, verifique en la tabla de trabajador o diríjase a la parte buscar para buscar el trabajador");
                                }
                                else
                                {
                                    string fecha = "";
                                    CNAgregarTrabajador conex = new CNAgregarTrabajador();
                                    conex.insertarTrabajador(dateTimePicker1.Text, txtNombreTrabajador.Text, txtApellidoTrabajador.Text, comboBox1.Text, txtIdentificacionTrabajador.Text, txtTelefonoTrabajador.Text, txtEmailTrabajador.Text, txtDireccionTrabajador.Text, Convert.ToString(comboBox2.SelectedValue), fecha);
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

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnNuevoTrabajador_Click(object sender, EventArgs e)
        {
            txtNombreTrabajador.Text = "";
            txtNombreTrabajador_Leave(null, e);
            txtApellidoTrabajador.Text = "";
            txtApellidoTrabajador_Leave(null, e);
            txtIdentificacionTrabajador.Text = "";
            txtIdentificacionTrabajador_Leave(null, e);
            txtTelefonoTrabajador.Text = "";
            txtTelefonoTrabajador_Leave(null, e);
            txtEmailTrabajador.Text = "";
            txtEmailTrabajador_Leave(null, e);
            txtDireccionTrabajador.Text = "";
            txtDireccionTrabajador_Leave(null, e);
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

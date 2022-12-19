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
    public partial class Configuracion : Form
    {
        Imagen img = new Imagen();
        public Configuracion()
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

        private void Configuracion_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnEliminarConfiguracion_Click(object sender, EventArgs e)
        {
            CNAgregarUsuario usuario = new CNAgregarUsuario();
            AgregarUsuario crear = new AgregarUsuario();
            SqlDataReader Loguear1;
            usuario.dni = txtIdUsuarioConfiguracion.Text;
            usuario.usuario = txtUsuarioConfiguracion.Text;
            Loguear1 = usuario.VerificarDni();
            if (txtIdUsuarioConfiguracion.Text != "")
            {
                if (txtNombreConfiguracion.Text!="")
                {
                    if (textBox1.Text!="")
                    {
                        if (txtUsuarioConfiguracion.Text!="")
                        {
                            if (txtContrasenaUsuario.Text!="")
                            {
                                if (textBox2.Text!="")
                                {
                                    if (Loguear1.Read() == true)
                                    {
                                        MessageBox.Show("Ya existe otro usuario con la misma DNI o con el mismo USUARIO");
                                    }
                                    else
                                    {
                                        img.insertarImagen(txtIdUsuarioConfiguracion.Text, txtNombreConfiguracion.Text, textBox1.Text, txtUsuarioConfiguracion.Text, txtContrasenaUsuario.Text, textBox2.Text, Convert.ToInt32(comboBox1.SelectedValue),pictureBox2);
                                        MessageBox.Show("Se agregó correctamente");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Ingrese el E-mail");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ingrese la contraseña");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingrese el usuario");
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
            else
            {
                MessageBox.Show("Ingrese la DNI");
            }
        }

        private void ListaAdministrador()
        {
            CNAgregarUsuario obj = new CNAgregarUsuario();
            comboBox1.DataSource = obj.MostrarAdministrador();
            comboBox1.DisplayMember = "Nivel_Usuario";
            comboBox1.ValueMember = "ID_Nivel";
        }

        private void Configuracion_Load(object sender, EventArgs e)
        {
            img.abrirConexion();
            ListaAdministrador();
        }

        private void btnRegistrarConfigurar_Click(object sender, EventArgs e)
        {
            txtIdUsuarioConfiguracion.Clear();
            txtNombreConfiguracion.Clear();
            textBox1.Clear();
            txtUsuarioConfiguracion.Clear();
            txtContrasenaUsuario.Clear();
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.ShowDialog();
                if (this.openFileDialog1.FileName.Equals("") == false)
                {
                    pictureBox2.Load(this.openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la imagen: " + ex.ToString());
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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

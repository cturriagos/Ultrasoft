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
    public partial class consulta : Form
    {
        Imagen img = new Imagen();
        public consulta()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);

        private void consulta_Load(object sender, EventArgs e)
        {
            ListaUsuario();
            img.abrirConexion();
        }

        private void btnActulizarDato_Click(object sender, EventArgs e)
        {
            try
            {
                img.actualizar(Convert.ToInt32(textBox3.Text), txtIdUsuarioConfiguracion.Text, txtNombreConfiguracion.Text, textBox1.Text, txtUsuarioConfiguracion.Text, txtContrasenaUsuario.Text, textBox2.Text, Convert.ToInt32(comboBox1.SelectedValue), pictureBox3);
                MessageBox.Show("Se actualizó correctamente los datos ");
                textBox3.Clear();
                txtIdUsuarioConfiguracion.Clear();
                txtNombreConfiguracion.Clear();
                textBox1.Clear();
                txtUsuarioConfiguracion.Clear();
                txtContrasenaUsuario.Clear();
                textBox2.Clear();
                txtCodigoCliente.Clear();
                if (txtUsuarioConfiguracion.Text != "")
                {
                    img.verImagen(pictureBox3, txtUsuarioConfiguracion.Text);
                }
                else
                {
                    pictureBox3.Image = imageList1.Images[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("no: " + ex);
            }

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void consulta_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            actualizar();
            if (txtUsuarioConfiguracion.Text != "")
            {
                img.verImagen(pictureBox3, txtUsuarioConfiguracion.Text);
            }
            else
            {
                pictureBox3.Image = imageList1.Images[0];
            }
            
        }

        private void actualizar()
        {
            AgregarUsuario obj = new AgregarUsuario();
            comboBox9.DataSource = obj.MostrarDatos(txtCodigoCliente.Text);
            comboBox9.DisplayMember = "ID_Usuario";
            comboBox9.ValueMember = "ID_Usuario";
            textBox3.Enabled = false;
            textBox3.Text = Convert.ToString(comboBox9.SelectedValue);
            comboBox2.DataSource = obj.MostrarDatos(txtCodigoCliente.Text);
            comboBox2.DisplayMember = "DNI";
            comboBox2.ValueMember = "DNI";
            txtIdUsuarioConfiguracion.Text = Convert.ToString(comboBox2.SelectedValue);
            comboBox3.DataSource = obj.MostrarDatos(txtCodigoCliente.Text);
            comboBox3.DisplayMember = "Nombre_Usuario";
            comboBox3.ValueMember = "Nombre_Usuario";
            txtNombreConfiguracion.Text = Convert.ToString(comboBox3.SelectedValue);
            comboBox4.DataSource = obj.MostrarDatos(txtCodigoCliente.Text);
            comboBox4.DisplayMember = "Apellido_Usuario";
            comboBox4.ValueMember = "Apellido_Usuario";
            textBox1.Text = Convert.ToString(comboBox4.SelectedValue);
            comboBox5.DataSource = obj.MostrarDatos(txtCodigoCliente.Text);
            comboBox5.DisplayMember = "Usuario";
            comboBox5.ValueMember = "Usuario";
            txtUsuarioConfiguracion.Text = Convert.ToString(comboBox5.SelectedValue);
            comboBox6.DataSource = obj.MostrarDatos(txtCodigoCliente.Text);
            comboBox6.DisplayMember = "Contraseña";
            comboBox6.ValueMember = "Contraseña";
            txtContrasenaUsuario.Text = Convert.ToString(comboBox6.SelectedValue);
            comboBox7.DataSource = obj.MostrarDatos(txtCodigoCliente.Text);
            comboBox7.DisplayMember = "Email";
            comboBox7.ValueMember = "Email";
            textBox2.Text = Convert.ToString(comboBox7.SelectedValue);
            comboBox8.DataSource = obj.MostrarDatos(txtCodigoCliente.Text);
            comboBox8.DisplayMember = "ID_Nivel";
            comboBox8.ValueMember = "ID_Nivel";
            comboBox1.SelectedItem =Convert.ToInt32( comboBox8.SelectedValue);
        }

        private void ListaUsuario()
        {
            CNAgregarUsuario obj = new CNAgregarUsuario();
            comboBox1.DataSource = obj.MostrarAdministrador();
            comboBox1.DisplayMember = "Nivel_Usuario";
            comboBox1.ValueMember = "ID_Nivel";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.ShowDialog();
                if (this.openFileDialog1.FileName.Equals("") == false)
                {
                    pictureBox3.Load(this.openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la imagen: " + ex.ToString());
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

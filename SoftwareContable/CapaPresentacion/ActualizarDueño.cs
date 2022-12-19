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
    public partial class ActualizarDueño : Form
    {
        public ActualizarDueño()
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

        private void ActualizarDueño_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void actualizar()
        {
            CNDueñoComercial obj = new CNDueñoComercial();
            comboBox2.DataSource = obj.MostrarDatos(txtCodigoCliente.Text);
            comboBox2.DisplayMember = "Cod_Propietario";
            comboBox2.ValueMember = "Cod_Propietario";
            textBox6.Enabled = false;
            textBox6.Text = Convert.ToString(comboBox2.SelectedValue);
            comboBox4.DataSource = obj.MostrarDatos(txtCodigoCliente.Text);
            comboBox4.DisplayMember = "Nombre_Propietario";
            comboBox4.ValueMember = "Nombre_Propietario";
            textBox1.Text = Convert.ToString(comboBox4.SelectedValue);
            comboBox5.DataSource = obj.MostrarDatos(txtCodigoCliente.Text);
            comboBox5.DisplayMember = "Apellido_Propietario";
            comboBox5.ValueMember = "Apellido_Propietario";
            textBox2.Text = Convert.ToString(comboBox5.SelectedValue);
            comboBox6.DataSource = obj.MostrarDatos(txtCodigoCliente.Text);
            comboBox6.DisplayMember = "Identificacion";
            comboBox6.ValueMember = "Identificacion";
            textBox8.Text = Convert.ToString(comboBox6.SelectedValue);
            comboBox7.DataSource = obj.MostrarDatos(txtCodigoCliente.Text);
            comboBox7.DisplayMember = "Email_Propietario";
            comboBox7.ValueMember = "Email_Propietario";
            textBox4.Text = Convert.ToString(comboBox7.SelectedValue);
            comboBox8.DataSource = obj.MostrarDatos(txtCodigoCliente.Text);
            comboBox8.DisplayMember = "Telefono_Propietario";
            comboBox8.ValueMember = "Telefono_Propietario";
            textBox3.Text = Convert.ToString(comboBox8.SelectedValue);
            comboBox9.DataSource = obj.MostrarDatos(txtCodigoCliente.Text);
            comboBox9.DisplayMember = "Direccion_Domicilio";
            comboBox9.ValueMember = "Direccion_Domicilio";
            textBox5.Text = Convert.ToString(comboBox9.SelectedValue);
            comboBox10.DataSource = obj.MostrarDatos(txtCodigoCliente.Text);
            comboBox10.DisplayMember = "Tipo_Identificacion";
            comboBox10.ValueMember = "Tipo_Identificacion";
            comboBox1.SelectedItem = Convert.ToString(comboBox10.SelectedValue);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        private void btnActulizarDato_Click(object sender, EventArgs e)
        {
            try
            {
                CNDueñoComercial conex = new CNDueñoComercial();
                conex.actualizarDueño(textBox1.Text, textBox2.Text, comboBox1.Text, textBox8.Text, textBox4.Text, textBox3.Text, textBox5.Text, textBox6.Text);
                MessageBox.Show("Se actualizó correctamente los datos ");
                textBox6.Enabled = true;
                textBox6.Clear();
                textBox1.Clear();
                textBox2.Clear();
                textBox8.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                txtCodigoCliente.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se actualizó");
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

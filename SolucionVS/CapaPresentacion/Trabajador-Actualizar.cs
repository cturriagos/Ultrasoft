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
    public partial class Trabajador_Actualizar : Form
    {
        public Trabajador_Actualizar()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);

        private void Trabajador_Actualizar_Load(object sender, EventArgs e)
        {
            ListaDireccion();
        }

        private void actualizar()
        {
            CNAgregarTrabajador obj = new CNAgregarTrabajador();
            comboBox3.DataSource = obj.MostrarDatos(txtCodigoCliente.Text);
            comboBox3.DisplayMember = "Cod_Trabajador";
            comboBox3.ValueMember = "Cod_Trabajador";
            textBox6.Enabled = false;
            textBox6.Text = Convert.ToString(comboBox3.SelectedValue);
            comboBox9.DataSource = obj.MostrarDatos(txtCodigoCliente.Text);
            comboBox9.DisplayMember = "Facha_Registro";
            comboBox9.ValueMember = "Facha_Registro";
            textBox7.Text = Convert.ToString(comboBox9.SelectedValue);
            comboBox4.DataSource = obj.MostrarDatos(txtCodigoCliente.Text);
            comboBox4.DisplayMember = "Nombre_Trabajador";
            comboBox4.ValueMember = "Nombre_Trabajador";
            textBox1.Text = Convert.ToString(comboBox4.SelectedValue);
            comboBox5.DataSource = obj.MostrarDatos(txtCodigoCliente.Text);
            comboBox5.DisplayMember = "Apellido_Trabajador";
            comboBox5.ValueMember = "Apellido_Trabajador";
            textBox2.Text = Convert.ToString(comboBox5.SelectedValue);
            comboBox6.DataSource = obj.MostrarDatos(txtCodigoCliente.Text);
            comboBox6.DisplayMember = "Identificacion";
            comboBox6.ValueMember = "Identificacion";
            textBox8.Text = Convert.ToString(comboBox6.SelectedValue);
            comboBox7.DataSource = obj.MostrarDatos(txtCodigoCliente.Text);
            comboBox7.DisplayMember = "Telefono";
            comboBox7.ValueMember = "Telefono";
            textBox3.Text = Convert.ToString(comboBox7.SelectedValue);
            comboBox8.DataSource = obj.MostrarDatos(txtCodigoCliente.Text);
            comboBox8.DisplayMember = "Email";
            comboBox8.ValueMember = "Email";
            textBox4.Text = Convert.ToString(comboBox8.SelectedValue);
            comboBox10.DataSource = obj.MostrarDatos(txtCodigoCliente.Text);
            comboBox10.DisplayMember = "Direccion_Domicilio";
            comboBox10.ValueMember = "Direccion_Domicilio";
            textBox5.Text = Convert.ToString(comboBox10.SelectedValue);
            comboBox11.DataSource = obj.MostrarDatos(txtCodigoCliente.Text);
            comboBox11.DisplayMember = "Tipo_Identificacion";
            comboBox11.ValueMember = "Tipo_Identificacion";
            comboBox1.SelectedItem = Convert.ToString(comboBox11.SelectedValue);
            comboBox12.DataSource = obj.MostrarDatos(txtCodigoCliente.Text);
            comboBox12.DisplayMember = "Direccion_Comercial";
            comboBox12.ValueMember = "Direccion_Comercial";
            comboBox2.SelectedItem = Convert.ToString(comboBox12.SelectedValue);
        }

        private void ListaDireccion()
        {
            CNAgregarTrabajador obj = new CNAgregarTrabajador();
            comboBox2.DataSource = obj.trabajador();
            comboBox2.DisplayMember = "direccion";
            comboBox2.ValueMember = "direccion";
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Trabajador_Actualizar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnActulizarDato_Click(object sender, EventArgs e)
        {
            try
            {
                CNAgregarTrabajador conex = new CNAgregarTrabajador();
                conex.actualizar(textBox1.Text, textBox2.Text, comboBox1.Text, textBox8.Text, textBox3.Text, textBox4.Text, textBox5.Text, comboBox2.Text, dateTimePicker2.Text, textBox6.Text);
                MessageBox.Show("Se actualizó correctamente los datos ");
                textBox6.Enabled = true;
                textBox6.Clear();
                textBox7.Clear();
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

        private void button1_Click(object sender, EventArgs e)
        {
            ListaDireccion();
            actualizar();
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

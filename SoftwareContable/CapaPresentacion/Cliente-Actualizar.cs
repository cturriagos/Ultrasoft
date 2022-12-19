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
    public partial class Cliente_Actualizar : Form
    {
        public Cliente_Actualizar()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblCodigo_Click(object sender, EventArgs e)
        {

        }

        private void btnActulizarDato_Click(object sender, EventArgs e)
        {
            try
            {
                CNAgregarCliente conex = new CNAgregarCliente();
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

        private void Cliente_Actualizar_MouseDown(object sender, MouseEventArgs e)
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

        private void actualizar()
        {
            CNAgregarCliente obj = new CNAgregarCliente();
            comboBox3.DataSource = obj.MostrarDatos(Convert.ToInt32(txtCodigoCliente.Text));
            comboBox3.DisplayMember = "Cod_Cliente";
            comboBox3.ValueMember = "Cod_Cliente";
            textBox6.Enabled = false;
            textBox6.Text = Convert.ToString(comboBox3.SelectedValue);
            comboBox9.DataSource = obj.MostrarDatos(Convert.ToInt32(Convert.ToInt32(txtCodigoCliente.Text)));
            comboBox9.DisplayMember = "Fecha_Registro";
            comboBox9.ValueMember = "Fecha_Registro";
            textBox7.Text = Convert.ToString(comboBox9.SelectedValue);
            comboBox4.DataSource = obj.MostrarDatos(Convert.ToInt32(txtCodigoCliente.Text));
            comboBox4.DisplayMember = "Nombre_Cliente";
            comboBox4.ValueMember = "Nombre_Cliente";
            textBox1.Text = Convert.ToString(comboBox4.SelectedValue);
            comboBox5.DataSource = obj.MostrarDatos(Convert.ToInt32(txtCodigoCliente.Text));
            comboBox5.DisplayMember = "Apellido_Cliente";
            comboBox5.ValueMember = "Apellido_Cliente";
            textBox2.Text = Convert.ToString(comboBox5.SelectedValue);
            comboBox6.DataSource = obj.MostrarDatos(Convert.ToInt32(txtCodigoCliente.Text));
            comboBox6.DisplayMember = "Identificacion";
            comboBox6.ValueMember = "Identificacion";
            textBox8.Text = Convert.ToString(comboBox6.SelectedValue);
            comboBox7.DataSource = obj.MostrarDatos(Convert.ToInt32(txtCodigoCliente.Text));
            comboBox7.DisplayMember = "Telefono";
            comboBox7.ValueMember = "Telefono";
            textBox3.Text = Convert.ToString(comboBox7.SelectedValue);
            comboBox8.DataSource = obj.MostrarDatos(Convert.ToInt32(txtCodigoCliente.Text));
            comboBox8.DisplayMember = "Email";
            comboBox8.ValueMember = "Email";
            textBox4.Text = Convert.ToString(comboBox8.SelectedValue);
            comboBox10.DataSource = obj.MostrarDatos(Convert.ToInt32(txtCodigoCliente.Text));
            comboBox10.DisplayMember = "Direccion_Domicilio";
            comboBox10.ValueMember = "Direccion_Domicilio";
            textBox5.Text = Convert.ToString(comboBox10.SelectedValue);
            comboBox11.DataSource = obj.MostrarDatos(Convert.ToInt32(txtCodigoCliente.Text));
            comboBox11.DisplayMember = "Tipo_Identificacion";
            comboBox11.ValueMember = "Tipo_Identificacion";
            comboBox1.SelectedItem = Convert.ToString(comboBox11.SelectedValue);
            comboBox12.DataSource = obj.MostrarDatos(Convert.ToInt32(txtCodigoCliente.Text));
            comboBox12.DisplayMember = "Direccion_Comercial";
            comboBox12.ValueMember = "Direccion_Comercial";
            comboBox2.SelectedItem = Convert.ToString(comboBox12.SelectedValue);
        }

        private void ListaDireccion()
        {
            CNAgregarCliente obj = new CNAgregarCliente();
            comboBox2.DataSource = obj.clientes();
            comboBox2.DisplayMember = "direccion";
            comboBox2.ValueMember = "direccion";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListaDireccion();
            actualizar();
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

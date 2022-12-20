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
    public partial class ActualizarComercial : Form
    {
        public ActualizarComercial()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private void ActualizarComercial_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ListaDireccion()
        {
            CNDueñoComercial obj = new CNDueñoComercial();
            comboBox2.DataSource = obj.direcciones();
            comboBox2.DisplayMember = "Direccion_Comercial";
            comboBox2.ValueMember = "Direccion_Comercial";
        }

        private void ActualizarComercial_Load(object sender, EventArgs e)
        {
            ListaDireccion();
        }

        private void ListaPropietarios()
        {
            CNDueñoComercial obj = new CNDueñoComercial();
            comboBox1.DataSource = obj.propietario();
            comboBox1.DisplayMember = "Identificacion";
            comboBox1.ValueMember = "Cod_Propietario";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListaPropietarios();
            actualizar();
        }

        private void actualizar()
        {
            CNDueñoComercial obj = new CNDueñoComercial();
            comboBox3.DataSource = obj.direccionComercial(comboBox2.Text);
            comboBox3.DisplayMember = "Direccion_Comercial";
            comboBox3.ValueMember = "Direccion_Comercial";
            textBox6.Text = Convert.ToString(comboBox3.SelectedValue);
            comboBox4.DataSource = obj.direccionComercial(comboBox2.Text);
            comboBox4.DisplayMember = "Nombre_Comercial";
            comboBox4.ValueMember = "Nombre_Comercial";
            textBox7.Text = Convert.ToString(comboBox4.SelectedValue);
            comboBox5.DataSource = obj.direccionComercial(comboBox2.Text);
            comboBox5.DisplayMember = "Email_Comercial";
            comboBox5.ValueMember = "Email_Comercial";
            textBox1.Text = Convert.ToString(comboBox5.SelectedValue);
            comboBox6.DataSource = obj.direccionComercial(comboBox2.Text);
            comboBox6.DisplayMember = "Telefono_Comercial";
            comboBox6.ValueMember = "Telefono_Comercial";
            textBox2.Text = Convert.ToString(comboBox6.SelectedValue);
            comboBox7.DataSource = obj.direccionComercial(comboBox2.Text);
            comboBox7.DisplayMember = "Identificacion";
            comboBox7.ValueMember = "Cod_Propietario";
            comboBox1.SelectedItem = Convert.ToString(comboBox7.SelectedValue);
            comboBox8.DataSource = obj.direccionComercial(comboBox2.Text);
            comboBox8.DisplayMember = "NumeroLocal";
            comboBox8.ValueMember = "NumeroLocal";
        }

        private void btnActulizarDato_Click(object sender, EventArgs e)
        {
            CNDueñoComercial conex = new CNDueñoComercial();
            conex.ActualizarComercial(textBox6.Text, textBox7.Text, textBox1.Text, textBox2.Text, Convert.ToString(comboBox1.SelectedValue), Convert.ToString(comboBox8.SelectedValue));
            MessageBox.Show("Se actualizó correctamente los datos ");
            textBox6.Clear();
            textBox7.Clear();
            textBox1.Clear();
            textBox2.Clear();
            ListaDireccion();
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

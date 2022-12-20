using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;
using System.Data.SqlClient;
using System.Data;

namespace CapaPresentacion
{
    public partial class MenuConfiguracion : Form
    {
        public MenuConfiguracion()
        {
            InitializeComponent();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Configuracion f1 = new Configuracion();
            f1.ShowDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            consulta f1 = new consulta();
            f1.ShowDialog();
        }

        private void MenuConfiguracion_Load(object sender, EventArgs e)
        {
            MostrarUsuario();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dtgBusqueda.Columns.Clear();
            MostrarUsuario();
        }

        private void MostrarUsuario()
        {
            CNAgregarUsuario conex = new CNAgregarUsuario();
            dtgBusqueda.DataSource = conex.MostrarUsuarios();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            AgregarUsuario conexi = new AgregarUsuario();
            comboBox2.DataSource = conexi.ContarUsers();
            comboBox2.DisplayMember = "total";
            comboBox2.ValueMember = "total";
            if (comboBox2.Text=="1")
            {
                MessageBox.Show("No se puede eliminar ya que es el único usuario “administrador” y si llegase a eliminar el usuario, el programa funcionaria con errores o incluso no podrá ingresar.");
            }
            else
            {
                AgregarUsuario conex = new AgregarUsuario();
                string codigo;
                codigo = dtgBusqueda.CurrentRow.Cells["DNI"].Value.ToString();
                conex.eliminar(codigo);
                MostrarUsuario();
                MessageBox.Show("Eliminado correctamente");
            }
        }
    }
}

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

namespace CapaPresentacion
{
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            this.Mostrar();
            //this.OcultarColumnas();
        }

        private void Mostrar()
        {
            this.dgvEmpleados.DataSource = NEmpleado.Mostrar();
        }

        private void OcultarColumnas()
        {
            this.dgvEmpleados.Columns[0].Visible = false;
        }
    }
}

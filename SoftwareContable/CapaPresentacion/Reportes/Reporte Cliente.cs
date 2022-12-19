using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Reporte_Cliente : Form
    {
        public Reporte_Cliente()
        {
            InitializeComponent();
        }

        private void Reporte_Cliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'clientes.Cliente' Puede moverla o quitarla según sea necesario.
            this.ClienteTableAdapter.Fill(this.clientes.Cliente);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}

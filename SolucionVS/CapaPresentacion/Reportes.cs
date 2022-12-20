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
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reporte_Cliente frm = new Reporte_Cliente();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reporte_Trabajador frm = new Reporte_Trabajador();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reporte_Proveedores frm = new Reporte_Proveedores();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReporteCompra frm = new ReporteCompra();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Reporte_Ventas frm = new Reporte_Ventas();
            frm.ShowDialog();
        }
    }
}

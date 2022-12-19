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
    public partial class Reporte_Trabajador : Form
    {
        public Reporte_Trabajador()
        {
            InitializeComponent();
        }

        private void Reporte_Trabajador_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.Trabajadores' Puede moverla o quitarla según sea necesario.
            this.TrabajadoresTableAdapter.Fill(this.DataSet1.Trabajadores);

            this.reportViewer1.RefreshReport();
        }
    }
}

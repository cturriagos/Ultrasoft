﻿using System;
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
    public partial class Reporte_Ventas : Form
    {
        public Reporte_Ventas()
        {
            InitializeComponent();
        }

        private void Reporte_Ventas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet4.ReporteVenta' Puede moverla o quitarla según sea necesario.
            this.ReporteVentaTableAdapter.Fill(this.DataSet4.ReporteVenta);

            this.reportViewer1.RefreshReport();
           // this.reportViewer1.RefreshReport();
        }
    }
}

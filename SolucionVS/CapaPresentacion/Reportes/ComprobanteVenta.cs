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
    public partial class ComprobanteVenta : Form
    {
        private int _Num_Compra;

        public int Num_Compra
        {
            get { return _Num_Compra; }
            set { _Num_Compra = value; }
        }
        public ComprobanteVenta()
        {
            InitializeComponent();
        }

        private void ComprobanteVenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'venta.factura_Venta' Puede moverla o quitarla según sea necesario.
            this.factura_VentaTableAdapter.Fill(this.venta.factura_Venta, Num_Compra);

            this.reportViewer1.RefreshReport();
        }
    }
}

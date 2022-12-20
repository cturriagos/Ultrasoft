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
    public partial class REPORTEFACTURACOMPRA : Form
    {
        private int _Num_Venta;

        public int Num_Venta
        {
            get { return _Num_Venta; }
            set {_Num_Venta=value;}
        }
        public REPORTEFACTURACOMPRA()
        {
            InitializeComponent();
        }

        private void REPORTEFACTURACOMPRA_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.factura_Compra' Puede moverla o quitarla según sea necesario.
            this.factura_CompraTableAdapter.Fill(this.dsPrincipal.factura_Compra, Num_Venta);

            this.reportViewer1.RefreshReport();
        }
    }
}

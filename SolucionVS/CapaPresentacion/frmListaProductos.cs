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
    public partial class frmListaProductos : Form
    {
        private NProducto nProducto;

        public frmListaProductos()
        {
            InitializeComponent();
            this.nProducto = new NProducto();
            LoadProducts();
        }

        private void frmListaProductos_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadProducts()
        {
            try
            {
                this.dgvListaProductos.DataSource = nProducto.ObtenerProductos(txtBuscarProducto.Text);
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }


    }
}

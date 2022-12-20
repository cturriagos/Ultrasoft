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
    public partial class Bodega_Registro : Form
    {
        public Bodega_Registro()
        {
            InitializeComponent();
        }


        private void txtCodigoBodega_Enter_1(object sender, EventArgs e)
        {
            if (txtCodigoBodega.Text == "Codigo")
            {
                txtCodigoBodega.Text = "";
                txtCodigoBodega.ForeColor = Color.Black;
            }
        }

        private void txtCodigoBodega_Leave_1(object sender, EventArgs e)
        {
            if (txtCodigoBodega.Text == "")
            {
                txtCodigoBodega.Text = "Codigo";
                txtCodigoBodega.ForeColor = Color.Black;
            }
        }

        private void txtCodigoProductoBodega_Enter_1(object sender, EventArgs e)
        {
            if (txtCodigoProductoBodega.Text == "Codigo de producto")
            {
                txtCodigoProductoBodega.Text = "";
                txtCodigoProductoBodega.ForeColor = Color.Black;
            }
        }

        private void txtCodigoProductoBodega_Leave_1(object sender, EventArgs e)
        {

            if (txtCodigoProductoBodega.Text == "")
            {
                txtCodigoProductoBodega.Text = "Codigo de producto";
                txtCodigoProductoBodega.ForeColor = Color.Black;
            }
        }

        private void txtPesoTotalBodega_Enter_1(object sender, EventArgs e)
        {
            if (txtPesoTotalBodega.Text == "Peso total")
            {
                txtPesoTotalBodega.Text = "";
                txtPesoTotalBodega.ForeColor = Color.Black;
            }
        }

        private void txtPesoTotalBodega_Leave_1(object sender, EventArgs e)
        {
            if (txtPesoTotalBodega.Text == "")
            {
                txtPesoTotalBodega.Text = "Peso total";
                txtPesoTotalBodega.ForeColor = Color.Black;
            }
        }

        private void txtDireccionComercial_Enter_1(object sender, EventArgs e)
        {
            if (txtDireccionComercial.Text == "Direccion Comercial")
            {
                txtDireccionComercial.Text = "";
                txtDireccionComercial.ForeColor = Color.Black;
            }
        }

        private void txtDireccionComercial_Leave_1(object sender, EventArgs e)
        {
            if (txtDireccionComercial.Text == "")
            {
                txtDireccionComercial.Text = "Direccion Comercial";
                txtDireccionComercial.ForeColor = Color.Black;
            }
        }

        private void Bodega_Registro_Load(object sender, EventArgs e)
        {

        }

        private void txtCodigoBodega_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}

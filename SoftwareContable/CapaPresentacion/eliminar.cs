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
    public partial class eliminar : Form
    {
        int cont = 0;
        public eliminar()
        {
            InitializeComponent();
        }

        private void btnRegistroEliminar_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (cont==1)
            {
                CNRegistros conex = new CNRegistros();
                string codigo;
                if (dtgBusqueda.SelectedRows.Count > 0)
                {
                    DialogResult opcion;
                    opcion = MessageBox.Show("Se eliminara el registro. ¿Desea eliminar el registro?", "ELIMINAR REGISTRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (opcion == DialogResult.OK)
                    {
                        codigo = dtgBusqueda.CurrentRow.Cells["Número_Registro"].Value.ToString();
                        conex.eliminar(codigo);
                        bodega();
                        MessageBox.Show("Eliminado correctamente");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione la fila por favor");
                }
            }
            else
            {
                if(cont==2)
                {
                    CNRegistros conex = new CNRegistros();
                    string codigo;
                    string NumVenta;
                    CNRegistros conexi = new CNRegistros();
                    string COD;
                    COD = dtgBusqueda.CurrentRow.Cells["Número_compra"].Value.ToString();
                    comboBox1.DataSource = conexi.ContarCompra(COD);
                    comboBox1.DisplayMember = "total";
                    comboBox1.ValueMember = "total";
                    if (dtgBusqueda.SelectedRows.Count > 0)
                    {
                        DialogResult opcion;
                        opcion = MessageBox.Show("Se eliminara el registro. ¿Desea eliminar el registro?", "ELIMINAR REGISTRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (opcion == DialogResult.OK)
                        {
                            if (comboBox1.Text == "1")
                            {
                                NumVenta = dtgBusqueda.CurrentRow.Cells["Número_compra"].Value.ToString();
                                conex.eliminarCompra2(NumVenta);
                                COMPRAS();
                                MessageBox.Show("Eliminado correctamente");
                            }
                            else
                            {
                                codigo = dtgBusqueda.CurrentRow.Cells["Código_Producto"].Value.ToString();
                                NumVenta = dtgBusqueda.CurrentRow.Cells["Número_compra"].Value.ToString();
                                conex.eliminarCompra1(NumVenta, codigo);
                                COMPRAS();
                                MessageBox.Show("Eliminado correctamente");
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione la fila por favor");
                    }
                }
                else
                {
                    if (cont==3)
                    {
                        CNRegistros conex = new CNRegistros();
                        string codigo;
                        string NumVenta;
                        CNRegistros conexi = new CNRegistros();
                        string COD;
                        COD = dtgBusqueda.CurrentRow.Cells["Número_venta"].Value.ToString();
                        comboBox1.DataSource = conexi.ContarVentas(COD);
                        comboBox1.DisplayMember = "total";
                        comboBox1.ValueMember = "total";
                        if (dtgBusqueda.SelectedRows.Count > 0)
                        {
                            DialogResult opcion;
                            opcion = MessageBox.Show("Se eliminara el registro. ¿Desea eliminar el registro?", "ELIMINAR REGISTRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            if (opcion == DialogResult.OK)
                            {
                                if (comboBox1.Text =="1")
                                {
                                    NumVenta = dtgBusqueda.CurrentRow.Cells["Número_venta"].Value.ToString();
                                    conex.eliminarVenta2(NumVenta);
                                    ventas();
                                    MessageBox.Show("Eliminado correctamente");
                                }
                                else
                                {
                                    codigo = dtgBusqueda.CurrentRow.Cells["Código_Producto"].Value.ToString();
                                    NumVenta = dtgBusqueda.CurrentRow.Cells["Número_venta"].Value.ToString();
                                    conex.eliminarVenta1(NumVenta, codigo);
                                    ventas();
                                    MessageBox.Show("Eliminado correctamente");
                                }

                            }
                        }
                        else
                        {
                            MessageBox.Show("Seleccione la fila por favor");
                        }
                    }
                }
            }
        }

        private void btnBodegaRegistro_Click(object sender, EventArgs e)
        {
            bodega();
            cont = 1;
        }
        private void bodega()
        {
            CNRegistros conex = new CNRegistros();
            dtgBusqueda.DataSource = conex.MostrarBodega();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            COMPRAS();
            cont = 2;
        }
        private void COMPRAS()
        {
            CNRegistros conex = new CNRegistros();
            dtgBusqueda.DataSource = conex.MostrarCompras();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ventas();
            cont = 3;
        }
        private void ventas()
        {
            CNRegistros conex = new CNRegistros();
            dtgBusqueda.DataSource = conex.MostrarVentas();
        }

        private void dtgBusqueda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}

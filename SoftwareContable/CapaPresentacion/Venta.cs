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
using System.Runtime.InteropServices;

namespace CapaPresentacion
{
    public partial class Venta : Form
    {
        int F1 = 0, cont = 1, F2 = 2;
        int emergente = 0;
        decimal total = Convert.ToDecimal("100950.25");
        decimal totpa = 0;

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            txtNumeroFactura.Enabled = false;
            txtProveedor.Enabled = false;
            textBox4.Clear();
            textBox5.Clear();
            textBox7.Enabled = false;;
            pictureBox1.Visible = true;
            emergente = 1;
        }

        private void btnRegistrarCompra_Click(object sender, EventArgs e)
        {
            CNVentas conex = new CNVentas();
            if (txtNumeroFactura.Text != "")
            {
                if (txtProveedor.Text != "")
                {
                    if (comboBox1.Text != "")
                    {
                        if (textBox4.Text != "")
                        {
                            if (textBox5.Text != "")
                            {
                                if (textBox7.Text != "")
                                {
                                    VRFProveedor cliente = new VRFProveedor();
                                    SqlDataReader Loguear;
                                    cliente.Dni = textBox7.Text;
                                    cliente.codigo = Convert.ToInt32(txtProveedor.Text);
                                    Loguear = cliente.VerificarTodo();
                                    if (Loguear.Read() == true)
                                    {
                                        tipopeso();
                                        total = 0;
                                        dataGridView1.Rows.Add(F2);
                                        F2 = 1;
                                        dataGridView1[0, F1].Value = cont;
                                        dataGridView1[1, F1].Value = textBox5.Text;
                                        dataGridView1[2, F1].Value = comboBox1.Text;
                                        dataGridView1[3, F1].Value = textBox4.Text;
                                        decimal importe = Convert.ToDecimal(textBox4.Text, System.Globalization.CultureInfo.InvariantCulture);
                                        decimal importe2 = Convert.ToDecimal(textBox5.Text, System.Globalization.CultureInfo.InvariantCulture);
                                        if (comboBox3.Text == "Libra")
                                        {
                                            total = Convert.ToDecimal(importe);
                                            total = total * Convert.ToDecimal(importe2);
                                        }
                                        else
                                        {
                                            total = Convert.ToDecimal(importe);
                                            total = total * Convert.ToDecimal(importe2);
                                        }
                                        totpa = totpa + total;
                                        dataGridView1[4, F1].Value = total.ToString("N2");
                                        F1 = F1 + 1;
                                        dataGridView1[3, F1].Value = "TOTAL A PAGAR";
                                        dataGridView1[4, F1].Value = "$" + totpa.ToString("N2");
                                        cont++;
                                        try
                                        {
                                            if (emergente == 0)
                                            {
                                                conex.Insert(txtNumeroFactura.Text, dateTimePicker1.Text, txtProveedor.Text);
                                                NumeroFactura();
                                                conex.InsertarFac(Convert.ToString(comboBox2.SelectedValue), textBox5.Text, Convert.ToString(comboBox1.SelectedValue), textBox4.Text);
                                            }
                                            else
                                            {
                                                try
                                                {
                                                    NumeroFactura();
                                                    conex.InsertarFac(Convert.ToString(comboBox2.SelectedValue), textBox5.Text, Convert.ToString(comboBox1.SelectedValue), textBox4.Text);
                                                }
                                                catch (Exception ex)
                                                {
                                                    MessageBox.Show("No se pudo insertar porque:" + ex);
                                                }
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show("No se pudo insertar porque:" + ex);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("El código del cliente no coincide con la DNI ingresada");
                                    }
                                }
                                else
                                {
                                    tipopeso();
                                    total = 0;
                                    dataGridView1.Rows.Add(F2);
                                    F2 = 1;
                                    dataGridView1[0, F1].Value = cont;
                                    dataGridView1[1, F1].Value = textBox5.Text;
                                    dataGridView1[2, F1].Value = comboBox1.Text;
                                    dataGridView1[3, F1].Value = textBox4.Text;
                                    decimal importe = Convert.ToDecimal(textBox4.Text, System.Globalization.CultureInfo.InvariantCulture);
                                    decimal importe2 = Convert.ToDecimal(textBox5.Text, System.Globalization.CultureInfo.InvariantCulture);
                                    if (comboBox3.Text == "Libra")
                                    {
                                        total = Convert.ToDecimal(importe);
                                        total = total * Convert.ToDecimal(importe2);
                                    }
                                    else
                                    {
                                        total = Convert.ToDecimal(importe);
                                        total = total * Convert.ToDecimal(importe2);
                                    }
                                    totpa = totpa + total;
                                    dataGridView1[4, F1].Value = total.ToString("N2");
                                    F1 = F1 + 1;
                                    dataGridView1[3, F1].Value = "TOTAL A PAGAR";
                                    dataGridView1[4, F1].Value = "$" + totpa.ToString("N2");
                                    cont++;
                                    try
                                    {
                                        if (emergente == 0)
                                        {
                                            conex.Insert(txtNumeroFactura.Text, dateTimePicker1.Text, txtProveedor.Text);
                                            NumeroFactura();
                                            conex.InsertarFac(Convert.ToString(comboBox2.SelectedValue), textBox5.Text, Convert.ToString(comboBox1.SelectedValue), textBox4.Text);
                                        }
                                        else
                                        {
                                            try
                                            {
                                                NumeroFactura();
                                                conex.InsertarFac(Convert.ToString(comboBox2.SelectedValue), textBox5.Text, Convert.ToString(comboBox1.SelectedValue), textBox4.Text);
                                            }
                                            catch (Exception ex)
                                            {
                                                MessageBox.Show("No se pudo insertar porque:" + ex);
                                            }
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("No se pudo insertar porque:" + ex);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ingrese el peso del producto");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingrese el precio");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un producto");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el código del cliente");
                }
            }
            else
            {
                MessageBox.Show("Ingrese el número de factura");
            }
        }

        private void MostrarProveedor()
        {
            dataGridView2.Columns.Clear();
            VRFProveedor proveedor = new VRFProveedor();
            SqlDataReader Loguear;
            proveedor.dni = textBox7.Text;
            Loguear = proveedor.Verificar();
            if (textBox7.Text!="")
            {
                if (Loguear.Read() == true)
                {
                    CNVentas conex = new CNVentas();
                    dataGridView2.DataSource = conex.mostrarTabla(textBox7.Text);
                    dataGridView2.Visible = true;
                }
                else
                {
                    dataGridView2.Visible = false;
                    dtgBusqueda.Visible = true;
                    MessageBox.Show("No existe registro del proveedor");
                }
            }
            else
            {
                MessageBox.Show("Ingrese la DNI");
            }
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            ListaProducto();
        }

        private void ListaProducto()
        {
            CN_CompraProducto obj = new CN_CompraProducto();
            comboBox1.DataSource = obj.MostrarProductos();
            comboBox1.DisplayMember = "Nom_Producto";
            comboBox1.ValueMember = "Cod_Producto";
            comboBox1.Text = "";
        }

        private void NumeroFactura()
        {
            CNVentas obj = new CNVentas();
            comboBox2.DataSource = obj.MostrarFactura();
            comboBox2.DisplayMember = "venta";
            comboBox2.ValueMember = "venta";
        }

        private void txtNumeroFactura_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ValidarLetraOnumero.SoloNumeros(e);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarLetraOnumero.SoloNumeros(e);
        }

        private void txtProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarLetraOnumero.SoloNumeros(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarLetraOnumero.NumerosDecimales(e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarLetraOnumero.NumerosDecimales(e);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarProveedor();
        }

        public Venta()
        {
            InitializeComponent();
        }

        private void btnNuevoCompra_Click(object sender, EventArgs e)
        {
            F1 = 0;
            cont = 1;
            F2 = 2;
            totpa = 0;
            emergente = 0;
            txtNumeroFactura.Enabled = true;
            textBox7.Enabled = true;
            txtProveedor.Enabled = true;
            txtProveedor.Clear();
            txtNumeroFactura.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox7.Clear();
            dataGridView1.Rows.Clear();
            dtgBusqueda.Rows.Clear();
            pictureBox1.Visible = true;
            dataGridView2.Visible = false;
            dtgBusqueda.Visible = true;
        }

        private void tipopeso()
        {
            CN_CompraProducto obj = new CN_CompraProducto();
            comboBox3.DataSource = obj.ProductosPeso(comboBox1.Text);
            comboBox3.DisplayMember = "Tipo_Peso";
            comboBox3.ValueMember = "Tipo_Peso";
        }

        private void button2_Click(object sender, EventArgs e)
        {
             DialogResult opcion;
             opcion = MessageBox.Show("TOTAL A COBRAR: " + totpa.ToString("N2") + " ¿Desea imprimir la factura?", "Venta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
             if (opcion == DialogResult.OK)
             {
                 ComprobanteVenta frm = new ComprobanteVenta();
                 frm.Num_Compra = Convert.ToInt32(comboBox2.SelectedValue);
                 frm.ShowDialog();
                 F1 = 0;
                 cont = 1;
                 F2 = 2;
                 totpa = 0;
                 emergente = 0;
                 txtNumeroFactura.Enabled = true;
                 textBox7.Enabled = true;
                 txtProveedor.Enabled = true;
                 txtProveedor.Clear();
                 txtNumeroFactura.Clear();
                 textBox4.Clear();
                 textBox5.Clear();
                 textBox7.Clear();
                 dataGridView1.Rows.Clear();
                 dtgBusqueda.Rows.Clear();
                 pictureBox1.Visible = true;
                 dataGridView2.Visible = false;
                 dtgBusqueda.Visible = true;
             }
             else
             {
                 F1 = 0;
                 cont = 1;
                 F2 = 2;
                 totpa = 0;
                 emergente = 0;
                 txtNumeroFactura.Enabled = true;
                 textBox7.Enabled = true;
                 txtProveedor.Enabled = true;
                 txtProveedor.Clear();
                 txtNumeroFactura.Clear();
                 textBox4.Clear();
                 textBox5.Clear();
                 textBox7.Clear();
                 dataGridView1.Rows.Clear();
                 dtgBusqueda.Rows.Clear();
                 pictureBox1.Visible = true;
                 dataGridView2.Visible = false;
                 dtgBusqueda.Visible = true;
             }
        }

    }
}

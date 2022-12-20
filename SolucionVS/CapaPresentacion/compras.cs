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
    public partial class Compras : Form
    {
        int F1 = 0, cont = 1, F2 = 2;
        int emergente = 0;
        decimal total = Convert.ToDecimal("100950.25");
        decimal totpa = 0;

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dtgbusqueda2.Visible = false;
            button2.Visible = true;
            label12.Visible = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox4.Clear();
            textBox5.Clear();
            textBox3.Enabled = false;
            pictureBox1.Visible = true;
            txtSuma.Visible = false;
            emergente = 1;
            comboBox1.Text = "";
        }

        private void btnNuevoCompra_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dtgbusqueda2.Visible = false;
            button2.Visible = true;
            label12.Visible = false;
            comboBox1.Text = "";
            F1 = 0;
            cont = 1;
            F2 = 2;
            totpa = 0;
            emergente = 0;
            textBox1.Enabled = true;
            textBox3.Enabled = true;
            textBox2.Enabled = true;
            textBox2.Clear();
            textBox1.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox3.Clear();
            dataGridView1.Rows.Clear();
            dtgBusqueda.Rows.Clear();
            pictureBox1.Visible = true;
            dataGridView2.Visible = false;
            dtgBusqueda.Visible = true;
            txtSuma.Visible = false;
        }

        private void btnRegistrarCompra_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dtgbusqueda2.Visible = false;
            label12.Visible = false;
            txtSuma.Visible = false;
            button2.Visible = true;
            CN_CompraProducto conex = new CN_CompraProducto();
           // if (textBox1.Text != "")
            //{
                //if (textBox2.Text != "")
                //{
                    if (comboBox1.Text != "")
                    {
                        if (textBox4.Text != "")
                        {
                            if (textBox5.Text != "")
                            {
                                if (textBox3.Text != "")
                                {
                                    VRFCliente cliente = new VRFCliente();
                                    SqlDataReader Loguear;
                                    //cliente.Dni = textBox2.Text;
                                    cliente.cod = Convert.ToInt32(textBox3.Text);
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
                                                conex.Insert(textBox1.Text, dateTimePicker1.Text, Convert.ToInt32(textBox3.Text));
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
                                        total = Convert.ToDecimal(importe) / 100;
                                        total = total * Convert.ToDecimal(importe2);
                                    }
                                    else
                                    {
                                        total = Convert.ToDecimal(importe);
                                        total = total * Convert.ToDecimal(importe2);
                                    }
                                    totpa = totpa + total;
                                    dataGridView1[4, F1].Value = total.ToString("N2"); ;
                                    F1 = F1 + 1;
                                    dataGridView1[3, F1].Value = "TOTAL A PAGAR";
                                    dataGridView1[4, F1].Value = "$" + totpa.ToString("N2");
                                    cont++;
                                    try
                                    {
                                        if (emergente == 0)
                                        {
                                            conex.Insert(textBox1.Text, dateTimePicker1.Text, Convert.ToInt32(textBox3.Text));
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
            //    else
            //    {
            //        MessageBox.Show("Ingrese el código del cliente");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Ingrese el número de factura");
            //}
        
                    
                
            
        
        private void MostrarCliente()
        {
            dataGridView2.Columns.Clear();
            VRFCliente cliente = new VRFCliente();
            SqlDataReader Loguear;
            cliente.cod = Convert.ToInt32(textBox3.Text);
            Loguear = cliente.Verificar();
            if (textBox3.Text!="")
            {
                if (Loguear.Read() == true)
                {
                    dtgBusqueda.Rows.Add(1);
                    CN_CompraProducto conex = new CN_CompraProducto();
                    dataGridView2.DataSource = conex.mostrarTabla(textBox3.Text);
                    dataGridView2.Visible = true;
                }
                else
                {
                    dataGridView2.Visible = false;
                    txtSuma.Visible = false;
                    dtgBusqueda.Visible = true;
                    label12.Visible = false;
                    MessageBox.Show("No existe registro del cliente");
                }
            }
            else
            {
                MessageBox.Show("Ingrese la DNI");
            }
        }

        private void Compras_Load(object sender, EventArgs e)
        {
            button3.Visible = false;
            ListaProducto();
            dtgbusqueda2.Visible = false;
            txtSuma.Visible = false;
            label12.Visible = false;

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
            CN_CompraProducto obj = new CN_CompraProducto();
            comboBox2.DataSource = obj.MostrarFactura();
            comboBox2.DisplayMember = "venta";
            comboBox2.ValueMember = "venta";
        }

        private void tipopeso()
        {
            CN_CompraProducto obj = new CN_CompraProducto();
            comboBox3.DataSource = obj.ProductosPeso(comboBox1.Text);
            comboBox3.DisplayMember = "Tipo_Peso";
            comboBox3.ValueMember = "Tipo_Peso";
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarLetraOnumero.SoloNumeros(e);

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarLetraOnumero.SoloNumeros(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
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
            MostrarCliente();
        }

        public Compras()
        {
            InitializeComponent();
        }

        private void btnMostrarVentas_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {

                VRFCliente cliente = new VRFCliente();
                SqlDataReader Loguear;
                //cliente.Dni = textBox2.Text;
                cliente.cod = Convert.ToInt32(textBox3.Text);

                dataGridView1.Visible = false;
                dtgbusqueda2.Visible = true;
                button2.Visible = false;
                txtSuma.Visible = true;
                label12.Visible = true;
                CNRegistros conex = new CNRegistros();

                dtgbusqueda2.DataSource = conex.CadaCliente(Convert.ToInt32(textBox3.Text));
                dtgbusqueda2.Columns[0].Width = 70;
                dtgbusqueda2.Columns[3].Width = 220;
                dtgbusqueda2.Columns[4].Width = 80;
            }
            else
            {
                MessageBox.Show("Ingrese el codigo");
            }
           
            double suma = 0;
            for (int i = 0; i < dtgbusqueda2.RowCount ; i++)
            {
                suma = suma + Convert.ToDouble(dtgbusqueda2[5,i].Value.ToString());
            }
            
            txtSuma.Location = new Point(1117, 532);
            txtSuma.Text = Convert.ToString(suma);
        
        }
        

        private void LBLCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             DialogResult opcion;
             opcion = MessageBox.Show("TOTAL A PAGAR: " + totpa.ToString("N2") + " ¿Desea imprimir la factura?", "Compra", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    REPORTEFACTURACOMPRA frm = new REPORTEFACTURACOMPRA();
                    frm.Num_Venta = Convert.ToInt32(comboBox2.SelectedValue);
                    frm.ShowDialog();
                    comboBox1.Text = "";
                    F1 = 0;
                    cont = 1;
                    F2 = 2;
                    totpa = 0;
                    emergente = 0;
                    textBox1.Enabled = true;
                    textBox3.Enabled = true;
                    textBox2.Enabled = true;
                    textBox2.Clear();
                    textBox1.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox3.Clear();
                    dataGridView1.Rows.Clear();
                    dtgBusqueda.Rows.Clear();
                    pictureBox1.Visible = true;
                    dataGridView2.Visible = false;
                    dtgBusqueda.Visible = true;
                }
                else
                {
                    comboBox1.Text = "";
                    F1 = 0;
                    cont = 1;
                    F2 = 2;
                    totpa = 0;
                    emergente = 0;
                    textBox1.Enabled = true;
                    textBox3.Enabled = true;
                    textBox2.Enabled = true;
                    textBox2.Clear();
                    textBox1.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox3.Clear();
                    dataGridView1.Rows.Clear();
                    dtgBusqueda.Rows.Clear();
                    pictureBox1.Visible = true;
                    dataGridView2.Visible = false;
                    label12.Visible = false;
                    txtSuma.Visible = false;
                    dtgBusqueda.Visible = true;
                }
        }

        private void dtgbusqueda2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           dataGridView1.Visible = true;
            label12.Visible = false;
            txtSuma.Visible = false;
            dtgbusqueda2.Visible = false;
            button2.Visible = true;
        }
    }
}

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
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            this.Mostrar();
            this.OcultarColumnas();
        }

        private void Mostrar()
        {
            this.dgvEmpleados.DataSource = NEmpleado.Mostrar();
        }

        private void OcultarColumnas()
        {
            this.dgvEmpleados.Columns[0].Visible = false;
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Ultrasoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "Ultrasoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {

                string Rpta = "";
                if (this.txtNombre.Text == string.Empty || 
                    this.txtDireccion.Text == string.Empty ||
                    this.txtEmail.Text == string.Empty ||
                    this.txtTelefono.Text == string.Empty ||
                    this.cmbTipo_identificacion.Text == string.Empty)
                {
                    MensajeError("Falta Ingresar algunos valores serán remarcados");
                    //erroricono.SetError(txtNombre, "Ingrese Nombre");
                }
                else
                {
                        //Vamos a insertar un producto
                        Rpta = NEmpleado.Registrar(this.cmbTipo_identificacion.Text,
                                                   this.txtNombre.Text.ToUpper(), 
                                                   this.txtDireccion.Text.ToUpper(),
                                                   this.txtTelefono.Text.ToUpper(),
                                                   this.txtEmail.Text.ToUpper());
                    //Si la respuesta fue OK, fue porque se modifico
                    //o inserto el Producto
                    //de forma correcta
                    if (Rpta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOK("Se insertó de forma correcta el registro");
                        }
                        else
                        {
                            this.MensajeOK("Se actualizó de forma correcta el registro");
                        }

                    }
                    else
                    {
                        //Mostramos el mensaje de error
                        this.MensajeError(Rpta);
                    }
                    this.IsNuevo = false;
                    this.IsModificar = false;
                    this.Botones();
                    this.Limpiar();
                    this.Mostrar();
                    this.txtIdcategoria.Text = "";

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}

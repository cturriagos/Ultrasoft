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

        private void Limpiar()
        {
            this.txtNombre.Text = string.Empty;
            this.txtDireccion.Text = string.Empty;
            this.txtEmail.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;
            this.cmbTipo_identificacion.SelectedIndex = -1;
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
                    string cmb = "";
                    if (this.cmbTipo_identificacion.Text == "Cédula")
                    {
                        cmb = "C";
                    }
                    else if (this.cmbTipo_identificacion.Text == "Ruc")
                    {
                        cmb = "R";
                    }
                    else
                    {
                        cmb = "P";
                    }

                    Rpta = NEmpleado.Registrar(cmb,
                                               this.txtNombre.Text.ToUpper(), 
                                               this.txtDireccion.Text.ToUpper(),
                                               this.txtTelefono.Text.ToUpper(),
                                               this.txtEmail.Text.ToUpper());
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOK("Se insertó de forma correcta el empleado");
                    }
                    else
                    {
                        //Mostramos el mensaje de error
                        this.MensajeError(Rpta);
                    }
                    this.Mostrar();
                    this.Limpiar();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}

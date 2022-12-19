using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CapaNegocios;
using System.Data.SqlClient;
using System.Data;

namespace CapaPresentacion
{
    public partial class Logim : Form
    {
        Imagen img = new Imagen();
        public Logim()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);

        private void Logim_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ptbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ptbminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            CNUsuario objUsuario = new CNUsuario();
            SqlDataReader Loguear;
            objUsuario.Usuario = txtusuario.Text;
            objUsuario.Contraseña = txtContrasena.Text;
            if (objUsuario.Usuario == txtusuario.Text)
            {
                lblErrorUsuario.Visible = false;
                if (objUsuario.Contraseña == txtContrasena.Text)
                {
                    lblErrorContraseña.Visible = false;
                    Loguear = objUsuario.IniciarSecion();
                    if (Loguear.Read() == true)
                    {
                        this.Hide();
                        Inicio nuevaVentana = new Inicio();
                        nuevaVentana.Show();
                        Program.Cargo = Loguear["ID_Nivel"].ToString();
                    }
                    else
                    {
                        lblErrorLogin.Text = "Usuario o contraseña invalidas, intente de nuevo";
                        lblErrorLogin.Visible = true;
                        txtContrasena.Text = "";
                        txtContrasena_Leave(null, e);
                        txtusuario.Focus();
                    }
                }
                else
                {
                    lblErrorContraseña.Text = objUsuario.Contraseña;
                    lblErrorContraseña.Visible = true;
                    lblErrorLogin.Visible = false;
                }
            }
            else
            {
                lblErrorUsuario.Text = objUsuario.Usuario;
                lblErrorUsuario.Visible = true;
                lblErrorLogin.Visible = false;
            }
        }

        private void linkRecuperarContraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormularioRecuperarContraseña frc = new FormularioRecuperarContraseña();
            frc.ShowDialog();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtusuario_Enter(object sender, EventArgs e)
        {
            if (txtusuario.Text == "Usuario")
            {
                txtusuario.Text = "";
                txtusuario.ForeColor = Color.Green;
            }
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "Contraseña")
            {
                txtContrasena.Text = "";
                txtContrasena.ForeColor = Color.Green;
                txtContrasena.UseSystemPasswordChar = true;
            }
        }

        private void txtusuario_Leave(object sender, EventArgs e)
        {
            if (txtusuario.Text == "")
            {
                txtusuario.Text = "Usuario";
                txtusuario.ForeColor = Color.Blue;

            }
        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "")
            {
                txtContrasena.Text = "Contraseña";
                txtContrasena.ForeColor = Color.Blue;
                txtContrasena.UseSystemPasswordChar = false;
            }
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {
            CNUsuario objUsuario = new CNUsuario();
            SqlDataReader Loguear;
            objUsuario.usuario2 = txtusuario.Text;
            Loguear = objUsuario.VerificarUser();
            if (txtusuario.Text != "Usuario")
            {
                 if (Loguear.Read() == true)
                 {
                    img.verImagen(pictureBox3, txtusuario.Text);
                 }
                 else
                {
                    pictureBox3.Image = imageList1.Images[0];
                }
            }
        }

        private void Logim_Load(object sender, EventArgs e)
        {
            img.abrirConexion();
        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            CNUsuario objUsuario = new CNUsuario();
            SqlDataReader Loguear;
            comboBox1.DataSource = objUsuario.MostrarNivel(txtusuario.Text);
            comboBox1.DisplayMember = "ID_Nivel";
            comboBox1.ValueMember = "ID_Nivel";
            objUsuario.Usuario = txtusuario.Text;
            objUsuario.Contraseña = txtContrasena.Text;
            if (objUsuario.Usuario == txtusuario.Text)
            {
                lblErrorUsuario.Visible = false;
                if (objUsuario.Contraseña == txtContrasena.Text)
                {
                    lblErrorContraseña.Visible = false;
                    Loguear = objUsuario.IniciarSecion();
                    if (Loguear.Read() == true)
                    {
                        if (comboBox1.Text == "1")
                        {
                            this.Hide();
                            Inicio nuevaVentana = new Inicio();
                            nuevaVentana.Show();
                        }
                        else
                        {
                            if (comboBox1.Text=="2")
                            {
                                this.Hide();
                                nivel_de_usuario_2 nuevaVentana = new nivel_de_usuario_2();
                                nuevaVentana.Show();
                            }
                            else
                            {
                                if (comboBox1.Text=="3")
                                {
                                    this.Hide();
                                    nivel_de_usuario_3 nuevaVentana = new nivel_de_usuario_3();
                                    nuevaVentana.Show();
                                }
                            }
                        }
                    }
                    else
                    {
                        lblErrorLogin.Text = "Usuario o contraseña invalidas, intente de nuevo";
                        lblErrorLogin.Visible = true;
                        txtContrasena.Text = "";
                        txtContrasena_Leave(null, e);
                        txtusuario.Focus();
                    }
                }
                else
                {
                    lblErrorContraseña.Text = objUsuario.Contraseña;
                    lblErrorContraseña.Visible = true;
                    lblErrorLogin.Visible = false;
                }
            }
            else
            {
                lblErrorUsuario.Text = objUsuario.Usuario;
                lblErrorUsuario.Visible = true;
                lblErrorLogin.Visible = false;
            }
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}

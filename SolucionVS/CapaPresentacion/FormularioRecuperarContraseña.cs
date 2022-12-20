using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CapaNegocios;

namespace CapaPresentacion
{
    public partial class FormularioRecuperarContraseña : Form
    {
        public FormularioRecuperarContraseña()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);

        CNUsuario objCN = new CNUsuario();

        private void ptbminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ptbCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            txtMensage.Text = objCN.RecuperarContra(txtDni.Text);

        }

        private void FormularioRecuperarContraseña_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

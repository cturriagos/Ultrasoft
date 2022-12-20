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

namespace CapaPresentacion
{
    public partial class nivel_de_usuario_3 : Form
    {
        public nivel_de_usuario_3()
        {
            InitializeComponent();
        }
        public const int WM_NCLBUTTONDOWN = 0xa1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hwnd, int Msg, int Wparam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void AbrirFormulario(object Formhijo)
        {
            if (this.pnlarea.Controls.Count > 0)
                this.pnlarea.Controls.RemoveAt(0);
            Form fn = Formhijo as Form;
            fn.TopLevel = false;
            fn.Dock = DockStyle.Fill;
            this.pnlarea.Controls.Add(fn);
            this.pnlarea.Tag = fn;
            fn.Show();
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new menuInicio());
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Registro());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Reportes());
        }

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void nivel_de_usuario_3_Load(object sender, EventArgs e)
        {
            AbrirFormulario(new menuInicio());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

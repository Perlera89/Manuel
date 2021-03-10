using Manuel02.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Calculadora;

namespace Manuel02
{
    public partial class frmMenu : Form
    {

        public frmMenu()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login form = new login();
            form.MdiParent = this;
            form.Show();
        }

        private void acerdaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcercaDe frm = new frmAcercaDe();
            frm.MdiParent = this;
            frm.Show();
        }

        //private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    frmListaUsuarioVisual frm = new frmListaUsuarioVisual();
        //    frm.MdiParent = this;
        //    frm.Show();
        //}

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMax.Visible = false;
            btnRest.Visible = true;
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRest.Visible = false;
            btnMax.Visible = true;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AbrirFormHijo(object formhijo)
        {
            if (this.Contenedor.Controls.Count > 0)
                this.Contenedor.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Contenedor.Controls.Add(fh);
            this.Contenedor.Tag = fh;
            fh.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmInicio());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new login());
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmUsuarios());
        }

        private void btnAcercade_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmAcercaDe());
        }

        private void Contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            pictureBox1_Click(null, e);
        }

        private void btnOperaciones_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmCalculadora());
        }
    }
}

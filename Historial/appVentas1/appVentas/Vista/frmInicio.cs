using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appVentas.Vista
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private const int tamanioGrid = 10;
        private const int areamouse = 132;
        private const int botonizquierdo = 17;
        private Rectangle rectanguloGrid;

        //Metodo para cambiar tamanio
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            //Area cliente del control
            var region = new Region(new Rectangle(0, 0, ClientRectangle.Width, ClientRectangle.Height));
            //creacion del rectangulo
            rectanguloGrid = new Rectangle(ClientRectangle.Width-tamanioGrid, ClientRectangle.Height-tamanioGrid, tamanioGrid, tamanioGrid);
            //Excluimos tamanio del formulario
            region.Exclude(rectanguloGrid);
            //Indicamos el panel principal
            panelPrincipal.Region = region;
            Invalidate();
        }

        //Metodo para cambiar tamanio
        protected override void WndProc(ref Message sms)
        {
            switch (sms.Msg)
            {
                case areamouse:
                    base.WndProc(ref sms);
                    //Establecemos el punto cliente para el area que se va minimizar
                    var RefPoint = PointToClient(new Point(sms.LParam.ToInt32() & 0xffff, sms.LParam.ToInt32() >> 16));
                    //Determinamos si se encuentra el punto en el area
                    if (!rectanguloGrid.Contains(RefPoint))
                    {
                        break;
                    }

                    //iniciamos instancia usando el puntero
                    sms.Result = new IntPtr(botonizquierdo);
                    break;
                default:
                    base.WndProc(ref sms);
                    break;
            }
        }

        //Estilos del rectangulo
        protected override void OnPaint(PaintEventArgs e)
        {
            //Establecemos color
            SolidBrush solid = new SolidBrush(Color.SteelBlue);
            e.Graphics.FillRectangle(solid, rectanguloGrid);

            //enviamos el color a la base
            base.OnPaint(e);

            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, rectanguloGrid);
        }

        //Maximizar y minimizar
        int lx, ly;
        int sw, sh;

        private void frmInicio_Load(object sender, EventArgs e)
        {
            AbrirFormulario<frmDefault>();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Estas seguro de cerrar el Programa?", "¡Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        //Maximizar
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            //Guarda la posicion actual
            lx = Location.X;
            ly = Location.Y;
            sw = Size.Width;
            sh = Size.Height;

            //ocupar toda la pantalla
            Size = Screen.PrimaryScreen.WorkingArea.Size;
            Location = Screen.PrimaryScreen.WorkingArea.Location;

            btnAmpliar.Visible = false;
            btnRestaurar.Visible = true;
        }

        //Restaurar
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            Size = new Size(sw, sh);
            Location = new Point(lx, ly);

            btnRestaurar.Visible = false;
            btnAmpliar.Visible = true;
        }

        private void btnCerrar_MouseEnter(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.Crimson;
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmProductos>();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmClientes>();
        }

        private void btnDocumentos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmDocumentos>();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmUsuarios>();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.Show();
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmDefault>();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelSuperior1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.RoyalBlue;
        }

        //Metodo para abrir un nuevo formulario en el contenedor
        private void AbrirFormulario<frmAbrir>() where frmAbrir : Form, new()
        {
            Form formularios;

            //abrimos el formulario en el contenedor
            formularios = panelContenedor.Controls.OfType<frmAbrir>().FirstOrDefault();

            if(formularios == null)
            {
                //abrimos un formulario secundario
                formularios = new frmAbrir
                {
                    TopLevel = false,
                    Dock = DockStyle.Fill
                };

                //agregamos el formulario al panel y lo traemos al frente
                panelContenedor.Controls.Add(formularios);
                panelContenedor.Tag = formularios;
                formularios.Show();

                formularios.BringToFront();
            }
            else
            {
                formularios.BringToFront();
            }
        }
    }
}

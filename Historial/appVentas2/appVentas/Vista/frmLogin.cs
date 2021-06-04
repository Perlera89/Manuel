using appVentas.DAO;
using appVentas.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appVentas
{
    //falta desarrollar el MDI
    public partial class Form1 : Form
    {
        ClsLoguin clsAcceso = new ClsLoguin();
        public Form1()
        {
            //Creamos un hilo
            Thread t = new Thread(new ThreadStart(SplashStart));

            //Arranca el hilo
            t.Start();

            //Ponemos a dormir la forma principal
            Thread.Sleep(6000);

            InitializeComponent();

            //Finalizamos el hilo
            t.Abort();
        }

        public void SplashStart()
        {
            Application.Run(new frmSplash());
        }


        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text.Equals(@"Correo electronico"))
            {
                txtEmail.Text = "";
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text.Equals(""))
            {
                txtEmail.Text = @"Correo electronico";
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text.Equals("Password"))
            {
                txtPass.Text = "";
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text.Equals(""))
            {
                txtPass.Text = "Password";
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btnCerrar_MouseEnter(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.Crimson;
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.RoyalBlue;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister registro = new frmRegister();
            registro.ShowDialog();
        }

        private void btnLoguin_Click(object sender, EventArgs e)
        {
            int valor = clsAcceso.Acceso(txtEmail.Text, txtPass.Text);

            if (valor == 1)
            {
                MessageBox.Show("Inicio de sesion valido", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmInicio frm = new frmInicio();
                frm.lblCorreo.Text = txtEmail.Text;
                frm.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Tu correo o clave son incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistema_ventasDataSet.tb_producto' Puede moverla o quitarla según sea necesario.

        }
    }
    
}

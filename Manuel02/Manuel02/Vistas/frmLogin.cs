using Manuel02.Dominio;
using Manuel02.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manuel02
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //Evento del boton entrar
            Entidades entidad = new Entidades();
            ClsLogin cls = new ClsLogin();

            //pasar datos de los textBox a las entidades
            entidad.User = txtUser.Text;
            entidad.Pass = txtPass.Text;

            int evaluacion = cls.accesso(entidad);

            if(evaluacion == 1)
            {
                MessageBox.Show("Bienvenido");
            }

            else
            {
                MessageBox.Show("Credenciales incorrectas");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

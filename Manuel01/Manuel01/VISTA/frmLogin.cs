using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manuel01.NEGOCIO;

namespace Manuel01
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Login login = new Login(); //Instancia de los atributos
            ClsLogin cls = new ClsLogin(); //Instanca de la logica

            login.User = txtUser.Text; //User recibe el valcor deel TextBox txtUser
            login.Pass = txtPass.Text; //Pass recibe el valor del TextBox txtPass

            int evaluacion = cls.acceso(login); //Recibe el valor booleano del metodo entrar()

            //Si el usuario y contrasenia son correctos muestra mensaje
            if (evaluacion == 1)
            {
                MessageBox.Show("\"Bienvenido al Portal\"");
            }
            else
            {
                MessageBox.Show("Datos incorrectos, vuelva a intentar."); //Muestra mensaje en ventana
            }

            //Cierra el formulario al darle click en aceptar
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

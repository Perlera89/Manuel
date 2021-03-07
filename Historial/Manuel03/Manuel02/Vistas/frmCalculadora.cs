using Calculadora.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        Atributos atributos = new Atributos(); //Instancia de los atributos
        public frmCalculadora()
        {
            InitializeComponent();
        }

        Negocio.ClsOperacionesMat obj = new Negocio.ClsOperacionesMat(); //Instancia de la logica

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //btn1
        private void btn1_Click(object sender, EventArgs e)
        {
            txtDatos.Text = txtDatos.Text + "1";
        }
        
        //btn2
        private void btn2_Click(object sender, EventArgs e)
        {
            txtDatos.Text = txtDatos.Text + "2";
        }

        //btn3
        private void btn3_Click(object sender, EventArgs e)
        {
            txtDatos.Text = txtDatos.Text + "3";
        }

        //btn4
        private void btn4_Click(object sender, EventArgs e)
        {
            txtDatos.Text = txtDatos.Text + "4";
        }
        
        //btn 5
        private void btn5_Click(object sender, EventArgs e)
        {
            txtDatos.Text = txtDatos.Text + "5";
        }

        //btn6
        private void btn6_Click(object sender, EventArgs e)
        {
            txtDatos.Text = txtDatos.Text + "6";
        }

        //btn7
        private void btn7_Click(object sender, EventArgs e)
        {
            txtDatos.Text = txtDatos.Text + "7";
        }

        //btn8
        private void btn8_Click(object sender, EventArgs e)
        {
            txtDatos.Text = txtDatos.Text + "8";
        }

        //btn9
        private void btn9_Click(object sender, EventArgs e)
        {
            txtDatos.Text = txtDatos.Text + "9";
        }

        //btnPunto
        private void btnPunto_Click(object sender, EventArgs e)
        {
            txtDatos.Text = txtDatos.Text + ".";
        }

        //btnMas
        private void btnMas_Click(object sender, EventArgs e)
        {
            atributos.Operador = "+";
            atributos.Primero = double.Parse(txtDatos.Text);
            txtDatos.Clear(); //limpia pantalla luego del operador suma
        }

        //btnMenos
        private void btnMenos_Click(object sender, EventArgs e)
        {
            atributos.Operador = "-";
            atributos.Primero = double.Parse(txtDatos.Text);
            txtDatos.Clear(); //limpia pantalla luego del operador resta
        }

        //btnPor
        private void btnPor_Click(object sender, EventArgs e)
        {
            atributos.Operador = "*";
            atributos.Primero = double.Parse(txtDatos.Text);
            txtDatos.Clear(); //limpia pantalla luego del operador multiplicacion
        }

        //btnEntre
        private void btnEntre_Click(object sender, EventArgs e)
        {
            atributos.Operador = "/";
            atributos.Primero = double.Parse(txtDatos.Text);
            txtDatos.Clear(); ////limpia pantalla luego del operador Division
        }

        //Logica del btnIgual
        private void btnIgual_Click(object sender, EventArgs e)
        {
            //Segunda cifra que recibe txtDatos
            atributos.Segundo = double.Parse(txtDatos.Text);

            //Condiones de suma, resta, multiplicacion y division

            switch(atributos.Operador)
            {
                case "+": //Muestra la suma
                    double Sum = obj.Suma((atributos.Primero), (atributos.Segundo));
                    txtDatos.Text = Sum.ToString();
                    break;

                case "-": //Muestra la resta
                    double Res = obj.Resta((atributos.Primero), (atributos.Segundo));
                    txtDatos.Text = Res.ToString();
                    break;

                case "*": //Muestra la multiplicacion
                    double Mult = obj.Multiplicacion((atributos.Primero), (atributos.Segundo));
                    txtDatos.Text = Mult.ToString();
                    break;

                case "/": //Muestra la division
                    double Div = obj.Division((atributos.Primero), (atributos.Segundo));
                    txtDatos.Text = Div.ToString();
                    break;
            }


        }

        //Limpia pantalla
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDatos.Clear();
        }

        //Borra un dato
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txtDatos.Text.Length == 1)
                txtDatos.Text = "";

            else
                txtDatos.Text = txtDatos.Text.Substring(0, txtDatos.Text.Length - 1);
        }
    }
}

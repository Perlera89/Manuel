using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appVentas.Vista
{
    public partial class frmSplash : Form
    {
        private int valuep = 0;
        public frmSplash()
        {
            InitializeComponent();
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Incrementar la barra
            valuep += 1;
            progresBar.Value = valuep;

            //Si llega al maximo paramos el timmer
            if (progresBar.Value == 100)
            {
                timer1.Stop();
                progresBar.Visible = false;
                Form1 frm = new Form1();
                
                this.Hide();
                frm.Show();
            }
        }
    }
}

using Manuel02.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manuel02.Vistas
{
    public partial class frmListaUsuarioVisual : Form
    {
        public frmListaUsuarioVisual()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmListaUsuarioVisual_Load(object sender, EventArgs e)
        {
            ClsListaUsuario cls = new ClsListaUsuario();

            foreach (var iteracion in cls.Users)
            {
                dataGridView1.Rows.Add(iteracion.ToString());
            }
        }
    }
}

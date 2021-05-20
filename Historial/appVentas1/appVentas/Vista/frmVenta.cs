using appVentas.Model;
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
    public partial class frmVenta : Form
    {
        public frmVenta()
        {
            InitializeComponent();
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            using (sistema_ventasEntities bd = new sistema_ventasEntities())
            {
                var clientes = bd.tb_cliente.ToList();

                cbCliente.DataSource = clientes;
                cbCliente.DisplayMember = "nombreCliente";
                cbCliente.ValueMember = "iDCliente";

                var documento = bd.tb_documento.ToList();

                cbTDocumento.DataSource = documento;
                cbTDocumento.DisplayMember = "nombreDocumento";
                cbTDocumento.ValueMember = "iDDocumento";
            }
        }
    }
}
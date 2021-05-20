using appVentas.DAO;
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
            ClsClientes cliente = new ClsClientes();
            ClsDocumentos documento = new ClsDocumentos();

                cbCliente.DataSource = cliente.CargarClientes();
                cbCliente.DisplayMember = "nombreCliente";
                cbCliente.ValueMember = "iDCliente";

                cbTDocumento.DataSource = documento.CargarDocumentos();
                cbTDocumento.DisplayMember = "nombreDocumento";
                cbTDocumento.ValueMember = "iDDocumento";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            VistaPractica.frmProductos buscar = new VistaPractica.frmProductos();
            buscar.Show();

        }
    }
}
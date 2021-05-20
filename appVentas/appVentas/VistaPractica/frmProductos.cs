using appVentas.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appVentas.VistaPractica
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        void CargarDatos()
        {
            var productos = new ClsProductos();

            dtgProductos.Rows.Clear();

            foreach(var datos in productos.CargarProductosFiltro(txtFiltro.Text))
            {
                dtgProductos.Rows.Add(datos.idProducto, datos.nombreProducto, datos.precioProducto, datos.estadoProducto);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void dtgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            frmVentaMenu.venta.txtId.Text = dtgProductos.CurrentRow.Cells[0].Value.ToString();
            frmVentaMenu.venta.txtNombre.Text = dtgProductos.CurrentRow.Cells[1].Value.ToString();
            frmVentaMenu.venta.txtPrecio.Text = dtgProductos.CurrentRow.Cells[2].Value.ToString();

            this.Close();
        }
    }
}

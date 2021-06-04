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

        private void UltimoCorrelativo()
        {
            var consultarVenta = new ClsVenta();

            int lista = 0;

            foreach (var list in consultarVenta.UltimaVenta())
            {
                lista = list.iDVenta;
            }

            lista++;

            txtUltimaVenta.Text = lista.ToString();
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            UltimoCorrelativo();
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
            buscar.ShowDialog();

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            Calcular();
        }

        private void Calcular()
        {
            try
            {
                double precio, cantidad, total;

                cantidad = Convert.ToDouble(txtCantidad.Text);
                precio = Convert.ToDouble(txtPrecio.Text);

                total = precio * cantidad;
                txtTotal.Text = total.ToString();
            }

            catch (Exception)
            {
                if (txtCantidad.Text.Equals(""))
                {
                    txtCantidad.Text = "1";
                    txtCantidad.SelectAll();
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Calcular();
            double suma = 0;
            dtgVenta.Rows.Add(txtId.Text, txtNombre.Text, txtPrecio.Text, txtCantidad.Text, txtTotal.Text);

            for(var i = 0; i < dtgVenta.Rows.Count; i++)
            {
                String datosOperacion = dtgVenta.Rows[i].Cells[4].Value.ToString();
                double datosConvertidos = Convert.ToDouble(datosOperacion);
                suma += datosConvertidos;
            }

            Limpiar();

            txtTotalNeto.Text = suma.ToString();

            dtgVenta.Refresh();
            dtgVenta.ClearSelection();
            int ultimaFila = dtgVenta.Rows.Count - 1;
            dtgVenta.FirstDisplayedScrollingRowIndex = ultimaFila;
            dtgVenta.Rows[ultimaFila].Selected = true;
        }

        void Limpiar()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
            txtTotal.Clear();
            txtTotalNeto.Clear();
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                txtCantidad.Focus();
                if (txtBuscar.Text.Equals(""))
                {
                    btnBuscar.PerformClick();
                }

                else
                {
                    ClsProductos productos = new ClsProductos();
                    var busqueda = productos.BuscarProductoId(Convert.ToInt32(txtBuscar.Text));

                    if(busqueda.Count < 1)
                    {
                        MessageBox.Show("El codigo ingresado no existe");
                        txtBuscar.Text = string.Empty;
                    }

                    foreach (var producto in busqueda)
                    {
                        txtId.Text = producto.idProducto.ToString();
                        txtNombre.Text = producto.nombreProducto;
                        txtPrecio.Text = producto.precioProducto.ToString();
                        txtCantidad.Text = "1";
                        txtCantidad.Focus();
                        txtBuscar.Clear();
                    }

                    e.Handled = true;
                }
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e){
            if (e.KeyChar == 13){
                e.Handled = true;
                btnAgregar.PerformClick();
                txtBuscar.Focus();
                txtTotal.Clear();
            }                             
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ClsVenta ventas = new ClsVenta();
                tb_venta venta = new tb_venta();
                venta.iDDocumento = Convert.ToInt32(cbCliente.SelectedValue.ToString());
                venta.iDCliente = Convert.ToInt32(cbCliente.SelectedValue.ToString());
                venta.iDUsuario = 1;
                venta.totalVenta = Convert.ToDecimal(txtTotalNeto.Text);
                venta.fecha = Convert.ToDateTime(dtpFecha.Text);
                ventas.GuardarVenta(venta);

                ClsDDetalle detalle = new ClsDDetalle();
                tb_detalleVenta tbDetalle = new tb_detalleVenta();

                foreach (DataGridViewRow dtg in dtgVenta.Rows)
                {
                    tbDetalle.iDVenta = Convert.ToInt32(txtUltimaVenta.Text);
                    tbDetalle.iDProducto = Convert.ToInt32(dtg.Cells[0].Value.ToString());
                    tbDetalle.cantidad = Convert.ToInt32(dtg.Cells[3].Value.ToString());
                    tbDetalle.precio = Convert.ToDecimal(dtg.Cells[2].Value.ToString());
                    tbDetalle.total = Convert.ToDecimal(dtg.Cells[4].Value.ToString());
                    detalle.GuardarDetalleVenta(tbDetalle);
                }

                UltimoCorrelativo();
                dtgVenta.Rows.Clear();
                txtTotal.Clear();
                MessageBox.Show("Save");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message);
            }
        }

        private void dtgVenta_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            Calcular();
        }
    }                                     
}                                         
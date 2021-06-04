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
    public partial class frmProductos : Form
    {
        ClsProductos productos = new ClsProductos();
        private bool editar = false;
        public frmProductos()
        {
            InitializeComponent();
            Cargar();
            Clean();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            tb_producto guardarProducto = new tb_producto();
            if (editar == false)
            {
                try
                {
                    if (txtId.Text == "")
                    {
                        guardarProducto.nombreProducto = txtProducto.Text;
                        guardarProducto.precioProducto = txtPrecio.Text;
                        guardarProducto.estadoProducto = txtEstado.Text;

                        productos.GuardarProductos(guardarProducto);
                        Cargar();
                        Clean();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                try
                {
                    guardarProducto.idProducto = Convert.ToInt32(txtId.Text);
                    guardarProducto.nombreProducto = txtProducto.Text;
                    guardarProducto.precioProducto = txtPrecio.Text;
                    guardarProducto.estadoProducto = txtEstado.Text;

                    productos.ActualizarProductos(guardarProducto);

                    Cargar();
                    Clean();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgProductos.SelectedRows.Count > 0)
                {
                    txtId.Text = dtgProductos.CurrentRow.Cells[0].Value.ToString();
                    productos.EliminarProductos(Convert.ToInt32(txtId.Text));

                    Cargar();
                    Clean();
                }
                else
                {
                    MessageBox.Show("Selecciona una fila", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if(dtgProductos.SelectedRows.Count > 0)
            {
                editar = true;
                txtId.Text = dtgProductos.CurrentRow.Cells[0].Value.ToString();
                txtProducto.Text = dtgProductos.CurrentRow.Cells[1].Value.ToString();
                txtPrecio.Text = dtgProductos.CurrentRow.Cells[2].Value.ToString();
                txtEstado.Text = dtgProductos.CurrentRow.Cells[3].Value.ToString();
            }
            else
            {
                MessageBox.Show("Selecciona una fila", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Clean()
        {
            txtProducto.Text = "";
            txtPrecio.Text = "";
            txtEstado.Text = "";
            txtId.Text = "";
        }
        private void Cargar()
        {
            dtgProductos.Rows.Clear();
            List<tb_producto> Lista = productos.CargarProductos();

            foreach (var iteracion in Lista)
            {
                dtgProductos.Rows.Add(iteracion.idProducto, iteracion.nombreProducto, iteracion.precioProducto, iteracion.estadoProducto);
            }
        }

        private void Buscar()
        {
            dtgProductos.Rows.Clear();
            using (sistema_ventasEntities bd = new sistema_ventasEntities())
            {
                var consulta = (from producto in bd.tb_producto
                                where producto.nombreProducto.Contains(txtBuscar.Text)
                                select new
                                {
                                    producto.idProducto,
                                    producto.nombreProducto,
                                    producto.precioProducto,
                                    producto.estadoProducto
                                }).ToList();

                foreach (var i in consulta)
                {
                    dtgProductos.Rows.Add(i.idProducto, i.nombreProducto, i.precioProducto, i.estadoProducto);
                }
            }
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Equals(@"Buscar"))
            {
                txtBuscar.Text = @"";
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Equals(""))
            {
                txtBuscar.Text = "Buscar";
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }
    }
}

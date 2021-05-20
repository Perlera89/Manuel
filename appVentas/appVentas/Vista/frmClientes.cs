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
    public partial class frmClientes : Form
    {
        ClsClientes clientes = new ClsClientes();
        private bool editar = false;
        public frmClientes()
        {
            InitializeComponent();
            Clean();
            Cargar();
        }

        private void Clean()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtDui.Text = "";
        }
        private void Cargar()
        {
            dtgClientes.Rows.Clear();
            List<tb_cliente> Lista = clientes.CargarClientes();

            foreach (var iteracion in Lista)
            {
                dtgClientes.Rows.Add(iteracion.iDCliente, iteracion.nombreCliente, iteracion.direccionCliente, iteracion.duiCliente);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            tb_cliente guardarCliente = new tb_cliente();
            if (editar == false)
            {
                try
                {
                    if (txtId.Text == "")
                    {
                        guardarCliente.nombreCliente = txtNombre.Text;
                        guardarCliente.direccionCliente = txtDireccion.Text;
                        guardarCliente.duiCliente = txtDui.Text;

                        clientes.GuardarCliente(guardarCliente);
                        Cargar();
                        Clean();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                try
                {
                    guardarCliente.iDCliente = Convert.ToInt32(txtId.Text);
                    guardarCliente.nombreCliente = txtNombre.Text;
                    guardarCliente.direccionCliente = txtDireccion.Text;
                    guardarCliente.duiCliente = txtDui.Text;

                    clientes.ActualizarCliente(guardarCliente);

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
                if (dtgClientes.SelectedRows.Count > 0)
                {
                    txtId.Text = dtgClientes.CurrentRow.Cells[0].Value.ToString();
                    clientes.EliminarCliente(Convert.ToInt32(txtId.Text));

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
            if (dtgClientes.SelectedRows.Count > 0)
            {
                editar = true;
                txtId.Text = dtgClientes.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dtgClientes.CurrentRow.Cells[1].Value.ToString();
                txtDireccion.Text = dtgClientes.CurrentRow.Cells[2].Value.ToString();
                txtDui.Text = dtgClientes.CurrentRow.Cells[3].Value.ToString();
            }
            else
            {
                MessageBox.Show("Selecciona una fila", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Buscar()
        {
            dtgClientes.Rows.Clear();
            using (sistema_ventasEntities bd = new sistema_ventasEntities())
            {
                var consulta = (from cliente in bd.tb_cliente
                                where cliente.nombreCliente.Contains(txtBuscar.Text)
                                select new
                                {
                                    cliente.iDCliente,
                                    cliente.nombreCliente,
                                    cliente.direccionCliente,
                                    cliente.duiCliente
                                }).ToList();

                foreach (var i in consulta)
                {
                    dtgClientes.Rows.Add(i.iDCliente, i.nombreCliente, i.direccionCliente, i.duiCliente);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
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
    }
}

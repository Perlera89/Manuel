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
    public partial class frmUsuarios : Form
    {
        ClsUsuarios usuarios = new ClsUsuarios();
        private bool editar = false;
        public frmUsuarios()
        {
            InitializeComponent();
            Cargar();
            Clean();
        }

        private void Clean()
        {
            txtId.Text = "";
            txtEmail.Text = "";
            txtPass.Text = "";

        }
        private void Cargar()
        {
            dtgUsuarios.Rows.Clear();
            List<tb_usuario> Lista = usuarios.CargarUsuarios();

            foreach (var iteracion in Lista)
            {
                dtgUsuarios.Rows.Add(iteracion.iDUsuario, iteracion.email, iteracion.contrasena);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            tb_usuario guardarUsuario = new tb_usuario();
            if (editar == false)
            {
                try
                {
                    if (txtId.Text == "")
                    {
                        guardarUsuario.email = txtEmail.Text;
                        guardarUsuario.contrasena = txtPass.Text;

                        usuarios.GuardarUsuarios(guardarUsuario);
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
                    guardarUsuario.iDUsuario = Convert.ToInt32(txtId.Text);
                    guardarUsuario.email = txtEmail.Text;
                    guardarUsuario.contrasena = txtPass.Text;

                    usuarios.ActualizarUsuarios(guardarUsuario);

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
                if (dtgUsuarios.SelectedRows.Count > 0)
                {
                    txtId.Text = dtgUsuarios.CurrentRow.Cells[0].Value.ToString();
                    usuarios.EliminarUsuarios(Convert.ToInt32(txtId.Text));

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
            if (dtgUsuarios.SelectedRows.Count > 0)
            {
                editar = true;
                txtId.Text = dtgUsuarios.CurrentRow.Cells[0].Value.ToString();
                txtEmail.Text = dtgUsuarios.CurrentRow.Cells[1].Value.ToString();
                txtPass.Text = dtgUsuarios.CurrentRow.Cells[2].Value.ToString();
            }
            else
            {
                MessageBox.Show("Selecciona una fila", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Buscar()
        {
            dtgUsuarios.Rows.Clear();
            using (sistema_ventasEntities bd = new sistema_ventasEntities())
            {
                var consulta = (from usuario in bd.tb_usuario
                                where usuario.email.Contains(txtBuscar.Text)
                                select new
                                {
                                    usuario.iDUsuario,
                                    usuario.email,
                                    usuario.contrasena,
                                }).ToList();

                foreach (var i in consulta)
                {
                    dtgUsuarios.Rows.Add(i.iDUsuario, i.email, i.contrasena);
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

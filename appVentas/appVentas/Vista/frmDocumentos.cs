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
    public partial class frmDocumentos : Form
    {
        ClsDocumentos documentos = new ClsDocumentos();
        private bool editar = false;
        public frmDocumentos()
        {
            InitializeComponent();
            Clean();
            Cargar();
        }

        private void Clean()
        {
            txtId.Text = "";
            txtNombre.Text = "";
        }
        private void Cargar()
        {
            dtgDocumentos.Rows.Clear();
            List<tb_documento> Lista = documentos.CargarDocumentos();

            foreach (var iteracion in Lista)
            {
                dtgDocumentos.Rows.Add(iteracion.iDDocumento, iteracion.nombreDocumento);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            tb_documento guardarDocumento = new tb_documento();
            if (editar == false)
            {
                try
                {
                    if (txtId.Text == "")
                    {
                        guardarDocumento.nombreDocumento = txtNombre.Text;

                        documentos.GuardarDocumentos(guardarDocumento);
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
                    guardarDocumento.iDDocumento = Convert.ToInt32(txtId.Text);
                    guardarDocumento.nombreDocumento = txtNombre.Text;

                    documentos.ActualizarDocumento(guardarDocumento);

                    Cargar();
                    Clean();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dtgDocumentos.SelectedRows.Count > 0)
            {
                editar = true;
                txtId.Text = dtgDocumentos.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dtgDocumentos.CurrentRow.Cells[1].Value.ToString();
            }
            else
            {
                MessageBox.Show("Selecciona una fila", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgDocumentos.SelectedRows.Count > 0)
                {
                    txtId.Text = dtgDocumentos.CurrentRow.Cells[0].Value.ToString();
                    documentos.EliminarDocumento(Convert.ToInt32(txtId.Text));

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

        private void Buscar()
        {
            dtgDocumentos.Rows.Clear();
            using (sistema_ventasEntities bd = new sistema_ventasEntities())
            {
                var consulta = (from documento in bd.tb_documento
                                where documento.nombreDocumento.Contains(txtBuscar.Text)
                                select new
                                {
                                    documento.iDDocumento,
                                    documento.nombreDocumento
                                }).ToList();

                foreach (var i in consulta)
                {
                    dtgDocumentos.Rows.Add(i.iDDocumento, i.nombreDocumento);
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

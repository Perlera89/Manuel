using Manuel02.Models;
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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
            Cargar();
            Clean();
            
        }
        void Clean()
        {
            txtId.Clear();
            txtUsuario.Clear();
            txtApellido.Clear();
            txtEdad.Clear();
            txtPass.Clear();
        }
        void Cargar()
        {
            dtgListaUsuarios.Rows.Clear();
            using (programacionEntities db = new programacionEntities())
            {
                var lista = db.UserList.ToList();
                foreach (var iteracion in lista)
                {
                    dtgListaUsuarios.Rows.Add(iteracion.Id, iteracion.NombreUsuario, iteracion.Apellido, iteracion.Edad, iteracion.Pass);
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
                using (programacionEntities db = new programacionEntities())
                {

                    try
                    {
                    UserList userAgregar = new UserList();

                    userAgregar.NombreUsuario = txtUsuario.Text;
                    userAgregar.Apellido = txtApellido.Text;
                    userAgregar.Edad = Convert.ToInt32(txtEdad.Text);
                    userAgregar.Pass = txtPass.Text;

                    db.UserList.Add(userAgregar);
                    db.SaveChanges();

                    MessageBox.Show("Agregado correctamente");

                    txtId.Text = "";
                    txtUsuario.Text = "";
                    txtApellido.Text = "";
                    txtEdad.Text = "";
                    txtPass.Text = "";

                } catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                Cargar();
                Clean();

            } 
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            using(programacionEntities db = new programacionEntities())
            {
                try
                {
                    int actualizar = Convert.ToInt32(txtId.Text);
                    UserList userEliminar = db.UserList.Where(x => x.Id == actualizar).FirstOrDefault();

                    userEliminar.NombreUsuario = txtUsuario.Text;
                    userEliminar.Apellido = txtApellido.Text;
                    userEliminar.Edad = Convert.ToInt32(txtEdad.Text);
                    userEliminar.Pass = txtPass.Text;
                    db.SaveChanges();

                    MessageBox.Show("Actualizado correctamente");

                    txtId.Text = "";
                    txtUsuario.Text = "";
                    txtApellido.Text = "";
                    txtEdad.Text = "";
                    txtPass.Text = "";

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                Cargar();
                Clean();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            using (programacionEntities db = new programacionEntities())
            {
                try
                {
                    int eliminar = Convert.ToInt32(txtId.Text);
                    UserList userEliminar = db.UserList.Where(x => x.Id == eliminar).FirstOrDefault();

                    db.UserList.Remove(userEliminar);
                    db.SaveChanges();
                    MessageBox.Show("Eliminado correctamente");

                    txtId.Text = "";
                    txtUsuario.Text = "";
                    txtApellido.Text = "";
                    txtEdad.Text = "";
                    txtPass.Text = "";
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                Cargar();
                Clean();
            }
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void dtgListaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String Id = dtgListaUsuarios.CurrentRow.Cells[0].Value.ToString();
            String Nombre = dtgListaUsuarios.CurrentRow.Cells[1].Value.ToString();
            String Apellido = dtgListaUsuarios.CurrentRow.Cells[2].Value.ToString();
            String Edad = dtgListaUsuarios.CurrentRow.Cells[3].Value.ToString();
            String Pass = dtgListaUsuarios.CurrentRow.Cells[4].Value.ToString();

            txtId.Text = Id;
            txtUsuario.Text = Nombre;
            txtApellido.Text = Apellido;
            txtEdad.Text = Edad;
            txtPass.Text = Pass;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Clean();
        }
    }
}

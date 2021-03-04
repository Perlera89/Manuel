using Manuel02.Modelo;
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
    public partial class frmEntidades : Form
    {
        public frmEntidades()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            using (programacionEntities db = new programacionEntities())
            {
                try
                {

                    UserList userlist = new UserList();
                    userlist.NombreUsuario = txtNombre.Text;
                    userlist.Apellido = txtApellido.Text;
                    userlist.Edad = Convert.ToInt32(txtEdad.Text);
                    userlist.Pass = txtPass.Text;

                    db.UserList.Add(userlist);
                    db.SaveChanges();
                    MessageBox.Show("Datos ingresados");

                }catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                using (programacionEntities db = new programacionEntities())
                {
                    int eliminar = Convert.ToInt32(txtId.Text);
                    UserList userListBorrar = new UserList();
                    userListBorrar = db.UserList.Find(eliminar);
                    db.UserList.Remove(userListBorrar);
                    db.SaveChanges();

                    MessageBox.Show("Deleted");

                }
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.ToString());
            }
        
    }
    }
}

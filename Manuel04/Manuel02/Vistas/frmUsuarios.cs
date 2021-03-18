using Manuel02.DAO;
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
            CDUserList cdUserList = new CDUserList();
            List<UserList> Lista = cdUserList.CargarDatos();

            foreach (var iteracion in Lista)
            {
                dtgListaUsuarios.Rows.Add(iteracion.Id, iteracion.NombreUsuario, iteracion.Apellido, iteracion.Edad, iteracion.Pass);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CDUserList daoUser = new CDUserList();
            UserList user = new UserList();
            if (txtId.Text == "")
            {
                user.NombreUsuario = txtUsuario.Text;
                user.Apellido = txtApellido.Text;
                user.Edad = Convert.ToInt32(txtEdad.Text);
                user.Pass = txtPass.Text;

                daoUser.GuardarDatos(user);
            }

            else
            {
                user.Id = Convert.ToInt32(txtId.Text);
                user.NombreUsuario = txtUsuario.Text;
                user.Apellido = txtApellido.Text;
                user.Edad = Convert.ToInt32(txtEdad.Text);
                user.Pass = txtPass.Text;
                daoUser.ActualizarDatos(user);
            }
            Cargar();
            Clean(); 
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CDUserList daoUser = new CDUserList();
            daoUser.EliminarDatos(Convert.ToInt32(txtId.Text));

            Cargar();
            Clean();
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

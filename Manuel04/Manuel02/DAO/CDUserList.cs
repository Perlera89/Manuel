using Manuel02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manuel02.DAO
{
	class CDUserList
	{
		public List<UserList> CargarDatos()
		{
			List<UserList> lista;
			using (programacionEntities db = new programacionEntities())
			{
				lista = db.UserList.ToList();
			}
			return lista;
		}

		public void GuardarDatos(UserList user)
		{
			using (programacionEntities db = new programacionEntities())
			{
				try
				{
					UserList userAgregar = new UserList();

					userAgregar.NombreUsuario = user.NombreUsuario;
					userAgregar.Apellido = user.Apellido;
					userAgregar.Edad = user.Edad;
					userAgregar.Pass = user.Pass;

					db.UserList.Add(userAgregar);
					db.SaveChanges();

					MessageBox.Show("Agregados correctamente");
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
		}

		public void EliminarDatos(int Id)
        {
			using (programacionEntities db = new programacionEntities())
            {
                try
                {
					int eliminar = Id;
					UserList userEliminar = db.UserList.Where(x => x.Id == eliminar).FirstOrDefault();

					db.UserList.Remove(userEliminar);
					db.SaveChanges();
					MessageBox.Show("Eliminado correctamente");
                } catch(Exception ex)
                {
					MessageBox.Show(ex.ToString());
                }
            }
        }

		public void ActualizarDatos(UserList user)
        {
            try
            {
				using (programacionEntities db = new programacionEntities())
                {
					int update = user.Id;
					UserList userActualizar = db.UserList.Where(x => x.Id == update).FirstOrDefault();
					userActualizar.NombreUsuario = user.NombreUsuario;
					userActualizar.Apellido = user.Apellido;
					userActualizar.Edad = user.Edad;
					userActualizar.Pass = user.Pass;

					db.SaveChanges();
					MessageBox.Show("Actualizados correctamente");
				}
            } catch(Exception ex)
            {
				MessageBox.Show(ex.ToString());
            }
        }
	}
}

using appVentas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appVentas.DAO
{
    class ClsUsuarios
    {
		public List<tb_usuario> CargarUsuarios()
		{
			List<tb_usuario> lista;
			using (sistema_ventasEntities db = new sistema_ventasEntities())
			{
				lista = db.tb_usuario.ToList();
			}
			return lista;
		}

		public void GuardarUsuarios(tb_usuario usuario)
		{
			using (sistema_ventasEntities db = new sistema_ventasEntities())
			{
				try
				{
					tb_usuario agregarUsuario = new tb_usuario();

					agregarUsuario.email = usuario.email;
					agregarUsuario.contrasena = usuario.contrasena;


					db.tb_usuario.Add(agregarUsuario);
					db.SaveChanges();

					MessageBox.Show("Agregado correctamente");
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
		}

		public void EliminarUsuarios(int Id)
		{
			using (sistema_ventasEntities db = new sistema_ventasEntities())
			{
				try
				{
					int eliminar = Id;
					tb_usuario eliminarUsuario = db.tb_usuario.Where(x => x.iDUsuario == eliminar).FirstOrDefault();

					db.tb_usuario.Remove(eliminarUsuario);
					db.SaveChanges();
					MessageBox.Show("Eliminado correctamente");
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
		}

		public void ActualizarUsuarios(tb_usuario usuario)
		{
			try
			{
				using (sistema_ventasEntities db = new sistema_ventasEntities())
				{
					int update = usuario.iDUsuario;
					tb_usuario agregarUsuario = db.tb_usuario.Where(x => x.iDUsuario == update).FirstOrDefault();
					agregarUsuario.email = usuario.email;
					agregarUsuario.contrasena = usuario.contrasena;

					db.SaveChanges();
					MessageBox.Show("Actualizados correctamente");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
	}
}

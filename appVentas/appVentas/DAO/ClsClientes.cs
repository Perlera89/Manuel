using appVentas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appVentas.DAO
{
    class ClsClientes
    {
		public List<tb_cliente> CargarClientes()
		{
			List<tb_cliente> lista;
			using (sistema_ventasEntities db = new sistema_ventasEntities())
			{
				lista = db.tb_cliente.ToList();
			}
			return lista;
		}

		public void GuardarCliente(tb_cliente cliente)
		{
			using (sistema_ventasEntities db = new sistema_ventasEntities())
			{
				try
				{
					tb_cliente agregarCliente = new tb_cliente();

					agregarCliente.nombreCliente = cliente.nombreCliente;
					agregarCliente.direccionCliente = cliente.direccionCliente;
					agregarCliente.duiCliente = cliente.duiCliente;


					db.tb_cliente.Add(agregarCliente);
					db.SaveChanges();

					MessageBox.Show("Agregado correctamente");
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
		}

		public void EliminarCliente (int Id)
		{
			using (sistema_ventasEntities db = new sistema_ventasEntities())
			{
				try
				{
					int eliminar = Id;
					tb_cliente eliminarCliente = db.tb_cliente.Where(x => x.iDCliente == eliminar).FirstOrDefault();

					db.tb_cliente.Remove(eliminarCliente);
					db.SaveChanges();
					MessageBox.Show("Eliminado correctamente");
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
		}

		public void ActualizarCliente(tb_cliente cliente)
		{
			try
			{
				using (sistema_ventasEntities db = new sistema_ventasEntities())
				{
					int update = cliente.iDCliente;
					tb_cliente agregarCliente = db.tb_cliente.Where(x => x.iDCliente == update).FirstOrDefault();
					agregarCliente.nombreCliente = cliente.nombreCliente;
					agregarCliente.direccionCliente = cliente.direccionCliente;
					agregarCliente.duiCliente = cliente.duiCliente;

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

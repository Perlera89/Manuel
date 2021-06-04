using appVentas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appVentas.DAO
{
	class ClsProductos
	{
		public List<tb_producto> CargarProductos()
		{
			List<tb_producto> lista;
			using (sistema_ventasEntities db = new sistema_ventasEntities())
			{
				lista = db.tb_producto.ToList();
			}
			return lista;
		}

		public void GuardarProductos(tb_producto producto)
		{
			using (sistema_ventasEntities db = new sistema_ventasEntities())
			{
				try
				{
					tb_producto agregarProducto = new tb_producto();

					agregarProducto.nombreProducto = producto.nombreProducto;
					agregarProducto.precioProducto = producto.precioProducto;
					agregarProducto.estadoProducto = producto.estadoProducto;

					db.tb_producto.Add(agregarProducto);
					db.SaveChanges();

					MessageBox.Show("Agregado correctamente");
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
		}

		public void EliminarProductos(int Id)
		{
			using (sistema_ventasEntities db = new sistema_ventasEntities())
			{
				try
				{
					int eliminar = Id;
					tb_producto eliminarProducto = db.tb_producto.Where(x => x.idProducto == eliminar).FirstOrDefault();

					db.tb_producto.Remove(eliminarProducto);
					db.SaveChanges();
					MessageBox.Show("Eliminado correctamente");
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
		}

		public void ActualizarProductos(tb_producto producto)
		{
			try
			{
				using (sistema_ventasEntities db = new sistema_ventasEntities())
				{
					int update = producto.idProducto;
					tb_producto agregarProducto = db.tb_producto.Where(x => x.idProducto == update).FirstOrDefault();
					agregarProducto.nombreProducto = producto.nombreProducto;
					agregarProducto.precioProducto = producto.precioProducto;
					agregarProducto.estadoProducto = producto.estadoProducto;

					db.SaveChanges();
					MessageBox.Show("Actualizados correctamente");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		public List<tb_producto> CargarProductosFiltro(string filtro)
		{
			List<tb_producto> productos = new List<tb_producto>();
			using (sistema_ventasEntities db = new sistema_ventasEntities())
			{
				productos = (from producto in db.tb_producto
							 where producto.nombreProducto.Contains(filtro)
							 select producto).ToList();
			}

			return productos;
		}

        public List<tb_producto> BuscarProductoId(int id)
        {
            List<tb_producto> producto = new List<tb_producto>();

            using (sistema_ventasEntities bd = new sistema_ventasEntities())
            {
                producto = (from lista in bd.tb_producto
                            where lista.idProducto == id
                            select lista).ToList();
            }

            return producto;
        }
    }
}

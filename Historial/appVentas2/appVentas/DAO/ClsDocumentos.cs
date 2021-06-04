using appVentas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appVentas.DAO
{
    class ClsDocumentos
    {
		public List<tb_documento> CargarDocumentos()
		{
			List<tb_documento> lista;
			using (sistema_ventasEntities db = new sistema_ventasEntities())
			{
				lista = db.tb_documento.ToList();
			}
			return lista;
		}

		public void GuardarDocumentos(tb_documento documento)
		{
			using (sistema_ventasEntities db = new sistema_ventasEntities())
			{
				try
				{
					tb_documento agregarDocumento = new tb_documento();

					agregarDocumento.nombreDocumento = documento.nombreDocumento;


					db.tb_documento.Add(agregarDocumento);
					db.SaveChanges();

					MessageBox.Show("Agregado correctamente");
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
		}

		public void EliminarDocumento(int Id)
		{
			using (sistema_ventasEntities db = new sistema_ventasEntities())
			{
				try
				{
					int eliminar = Id;
					tb_documento eliminarDocumento = db.tb_documento.Where(x => x.iDDocumento == eliminar).FirstOrDefault();

					db.tb_documento.Remove(eliminarDocumento);
					db.SaveChanges();
					MessageBox.Show("Eliminado correctamente");
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
		}

		public void ActualizarDocumento(tb_documento documento)
		{
			try
			{
				using (sistema_ventasEntities db = new sistema_ventasEntities())
				{
					int update = documento.iDDocumento;
					tb_documento agregarDocumento = db.tb_documento.Where(x => x.iDDocumento == update).FirstOrDefault();
					agregarDocumento.nombreDocumento = documento.nombreDocumento;

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

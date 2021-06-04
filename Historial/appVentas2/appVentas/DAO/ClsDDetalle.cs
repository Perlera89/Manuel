using appVentas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appVentas.DAO
{
    class ClsDDetalle
    {
        public void GuardarDetalleVenta(tb_detalleVenta detalle)
        {
            using (sistema_ventasEntities bd = new sistema_ventasEntities())
            {
                tb_detalleVenta tbDetalle = new tb_detalleVenta();
                tbDetalle.iDDetalleVenta = detalle.iDDetalleVenta;
                tbDetalle.iDProducto = detalle.iDProducto;
                tbDetalle.cantidad = detalle.cantidad;
                tbDetalle.precio = detalle.precio;
                tbDetalle.total = detalle.total;

                bd.SaveChanges();
            }
        }
    }
}

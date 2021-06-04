using appVentas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appVentas.DAO
{
    class ClsVenta
    {
        public List<tb_venta> UltimaVenta()
        {
            List<tb_venta> ConsultaUltimaVenta = new List<tb_venta>();

            using (sistema_ventasEntities bd = new sistema_ventasEntities())
            {
                ConsultaUltimaVenta = bd.tb_venta.ToList();
            }

            return ConsultaUltimaVenta;
        }

        public void GuardarVenta(tb_venta ventas)
        {
            using (sistema_ventasEntities bd = new sistema_ventasEntities())
            {
                tb_venta venta = new tb_venta();

                venta.iDDocumento = ventas.iDDocumento;
                venta.iDCliente = ventas.iDCliente;
                venta.iDUsuario = ventas.iDUsuario;
                venta.totalVenta = ventas.totalVenta;
                venta.fecha = ventas.fecha;
                bd.tb_venta.Add(venta);
                bd.SaveChanges();
            }
        }
        
    }
}

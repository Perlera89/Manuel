using appVentas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appVentas.DAO
{
    class ClsRegistro
    {
        public void RegistroUsuario(tb_usuario usuario)
        {
            using(sistema_ventasEntities db = new sistema_ventasEntities())
            {
                db.tb_usuario.Add(usuario);
                db.SaveChanges();
            }
        }
    }
}

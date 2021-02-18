using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manuel01.DOMINIO;

namespace Manuel01.NEGOCIO
{
    class ClsLogin
    {
        //Metodo entrar() compara el valor del User y Pass introducidos en sus respectivos TextBox.
        public int acceso(Login log)
        {
            int estado = 0;
            
            if (log.User.Equals("Manuel") && log.Pass.Equals("1234"))
            {
                estado = 1;
            }
            return estado;

        }
    }
}


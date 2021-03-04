using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manuel02.DAO;
using Manuel02.Dominio;

namespace Manuel02.Negocio
{
    class ClsLogin
    {
        ClsListaUsuario cls = new ClsListaUsuario();

        //Metodo entrar() compara el valor del User y Pass introducidos en sus respectivos TextBox.
        public int accesso(Entidades entidad)
        {
            int estado = 0;

            //copiando y almacenando los elementos del array
            cls.Users = cls.Users.Distinct().ToArray();
            cls.Passwords = cls.Passwords.Distinct().ToArray();

            //recorriendo arreglo para comparar
            for(int i = 0; i < cls.Users.Length; i++)
            {
                if(entidad.User.Equals(cls.Users[i]) && entidad.Pass.Equals(cls.Passwords[i]))
                {
                    estado = 1;
                }
            }

            return estado;
        }
    }
}

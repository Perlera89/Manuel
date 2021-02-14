using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manuel02.Dominio;

namespace Manuel02.Negocio
{
    class ClsLogin
    {
        //Metodo entrar() compara el valor del User y Pass introducidos en sus respectivos TextBox.
        public int accesso(Entidades entidad)
        {
        	//Declaracion de estado y listas que contienen los datos
            int estado = 0;

            string[] Users = new string[4] 
                { "Manuel", "Marcos", "Josue", "Wilian" };

            string[] Passwords = new string[4] 
                { "1234", "8930", "Kamy89", "Gatitos" };

            //copiando y almacenando los elementos del array
            Users = Users.Distinct().ToArray();
            Passwords = Passwords.Distinct().ToArray();

            //recorriendo arreglo para comparar
            for(int i = 0; i < Users.Length; i++)
            {
                if(entidad.User.Equals(Users[i]) && entidad.Pass.Equals(Passwords[i]))
                {
                    estado = 1;
                }
            }

            return estado;
        }
    }
}

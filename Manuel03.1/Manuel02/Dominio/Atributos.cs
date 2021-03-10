//Clase destinada para los atributos, los get y los set
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora.Dominio
{
    class Atributos
    {
        //Atributos numero1 y numero2 que almacenaran el valor de txtBox1 y txtBox2
        private double dato1, dato2, primero,segundo;
        private string operador;

        //Encapsulamiento para acceder a los atributos en otras clases
        public double Dato1 { get => dato1; set => dato1 = value; }
        public double Dato2 { get => dato2; set => dato2 = value; }
        public double Primero { get => primero; set => primero = value; }
        public double Segundo { get => segundo; set => segundo = value; }
        public string Operador { get => operador; set => operador = value; }

    }
}

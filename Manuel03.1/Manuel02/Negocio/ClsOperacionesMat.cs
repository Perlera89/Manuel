//clase destinada para la logica de la aplicacion
using Calculadora.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora.Negocio
{
    
    class ClsOperacionesMat
    {
        //La calculadora efectua las operaciones siguientes

        //Suma dos cantidades
        public double Suma(double Dato1, double Dato2)
        {
            double result = Dato1 + Dato2;
            return result;
        }

        //Resta dos cantidades
        public double Resta(double Dato1, double Dato2)
        {
            double result = Dato1 - Dato2;
            return result;
        }

        //Multiplica dos cantidades
        public double Multiplicacion(double Dato1, double Dato2)
        {
            double result = Dato1 * Dato2;
            return result;
        }

        //Divide dos cantidades
        public double Division(double Dato1, double Dato2)
        {
            double result = Dato1 / Dato2;
            return result;
        }

    }
}

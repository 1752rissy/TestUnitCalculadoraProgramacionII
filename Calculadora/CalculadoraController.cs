using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public  class CalculadoraController
    {
        ComputadoraController computadora;



        public int Sumar(int n1 , int n2)
        {
            int resultado = (n1 + n2);
            return resultado;
        }

        public int Multiplicar(int n1, int n2)
        {
            return (n1 * n2);   
        }

        public int Restar (int n1 , int n2)
        {
            return n1 - n2;
        }

        public float Dividir(int n1 , int n2)
        {
            float resultado = 0.0f;  
            if (n2 != 0)
            {
                resultado = n1 / n2;
                return resultado;
            }
            else
                return 0.0f;
        }

        public float Aumento(IOperaciones computadora,int numero, float porcentaje)
        {
            //FAKES, FALSIFICACIONES, HUMOS, SIMULARLO 
            float resultadoPorcentaje =  computadora.Porcentaje(numero, porcentaje);

            float aumento = Sumar(numero, (int)resultadoPorcentaje);

            return aumento;
        }

        public float Descuento(IOperaciones computadora,int numero, float porcentaje)
        {
            float resultadoPorcentaje = computadora.Porcentaje(numero, porcentaje);

            float descuento = Restar(numero, (int)resultadoPorcentaje);

            return descuento;
        }



    }
}

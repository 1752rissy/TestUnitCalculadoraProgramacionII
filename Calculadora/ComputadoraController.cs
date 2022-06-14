using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class ComputadoraController : IOperaciones
    {
        public  float Porcentaje(int numero, float porcentaje)
        {
            var resultado = numero * porcentaje;
            return resultado;
        }

        public float Factorial(int numero)
        {
            return 10f;
        }

        public float Raiz(int numero, int numero2)
        { return 10f; }

        public float Potencia(int numero, int numero2)
        {
            return numero * numero2;
        }
    }
}

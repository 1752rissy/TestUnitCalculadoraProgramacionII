using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class DispositivoMovilController : IOperaciones
    {
        public float Factorial(int numero)
        {
            throw new NotImplementedException();
        }

        public float Porcentaje(int numero, float porcentaje)
        {
            var resultadoFactorial = Factorial(10);
            var resultado = numero * porcentaje;
            return resultado;
        }

        public float Potencia(int numero, int numero2)
        {
            throw new NotImplementedException();
        }

        public float Raiz(int numero, int numero2)
        {
            throw new NotImplementedException();
        }
    }
}

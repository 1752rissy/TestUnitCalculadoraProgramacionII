using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public interface IOperaciones
    {
        float Porcentaje(int numero, float porcentaje);

        float Factorial(int numero);

        float Raiz(int numero, int numero2);

        float Potencia(int numero , int numero2);

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComputadoraController computadora = new ComputadoraController();

            CalculadoraController calculadoraController = new CalculadoraController();

            calculadoraController.Aumento(computadora, 10, 0.23f);
            calculadoraController.Descuento(computadora, 10, 0.23f);
            calculadoraController.Sumar(10, 20);
        }
    }
}

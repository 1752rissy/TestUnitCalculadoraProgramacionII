using NSubstitute;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class ComputadoraTests
    {
        [Test]
        public void Calcular_Aumento_Devolver_Resultado()
        {
            DispositivoMovilController controllerDispositivoMovil = new DispositivoMovilController();

             var operaciones = Substitute.For<IOperaciones>();

            operaciones.Factorial(Arg.Any<int>()).Returns(10f);

            var resultado = controllerDispositivoMovil.Porcentaje(10,12f);

            Assert.IsNotNull(resultado);

        }
    }
}

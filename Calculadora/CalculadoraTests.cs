using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;


namespace Calculadora
{
    [TestFixture]
    public class CalculadoraTests
    {
       [Test]
        public void Sumar_Dos_Numeros_Devolver_Suma()
        {
            //TRIPLE AAA
            //ARRANGE
            CalculadoraController controllerCalculadora = new CalculadoraController();
            int n1 = 10;
            int n2 = 20;
            //ACT 
            int resultado = controllerCalculadora.Sumar(n1, n2);

            //ASSERT 

            Assert.AreEqual(30, resultado);
        }

        [Test]
        public void Multiplicar_Dos_Numeros_Devolver_Resultado()
        {
            //TRIPLE AAA
            //ARRANGE
            CalculadoraController controllerCalculadora = new CalculadoraController();
            int n1 = 1;
            int n2 = 2;
            //ACT 
            int resultado = controllerCalculadora.Multiplicar(n1, n2);

            //ASSERT 

            Assert.AreEqual(2, resultado);
        }

        //CASO PESIMISTA
        [Test]
        public void Dividir_Dos_Numeros_Devolver_Resultado_DivisionSobre_cero()
        {
            //TRIPLE AAA
            //ARRANGE
            CalculadoraController controllerCalculadora = new CalculadoraController();
            int n1 = 2;
            int n2 = 0;
            //ACT 
            float resultado = controllerCalculadora.Dividir(n1, n2);

            //ASSERT 
            Assert.AreEqual(0.0f, resultado);
        }

        //CASO OPTIMISTA
        [Test]
        public void Dividir_Dos_Numeros_Devolver_Resultado_DivisionSobre_DevuelveDistintoCERO()
        {
            //TRIPLE AAA
            //ARRANGE
            CalculadoraController controllerCalculadora = new CalculadoraController();
            int n1 = 2;
            int n2 = 1;
            //ACT 
            float resultado = controllerCalculadora.Dividir(n1, n2);

            //ASSERT 

            Assert.AreEqual(2, resultado);
        }

        [Test]
        public void Calcular_Aumento_Devolver_Resultado()
        {
            CalculadoraController controllerCalculadora = new CalculadoraController();
            
            var computadoraController = Substitute.For<IOperaciones>();
 
            computadoraController.Porcentaje(Arg.Any<int>(), Arg.Any<float>()).Returns(10f);

            var resultado =  controllerCalculadora.Aumento(computadoraController, 10, 20.0f);

            Assert.IsNotNull(resultado);

        }






    }
}

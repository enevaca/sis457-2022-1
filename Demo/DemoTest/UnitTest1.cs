using DemoLibrary;

namespace DemoTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSuma()
        {
            // Arrange
            decimal numero1 = 5;
            decimal numero2 = 10;

            // Act
            decimal resultado = Calculadora.sumar(numero1, numero2);

            // Assert
            decimal valorEsperado = 15;
            Assert.AreEqual(valorEsperado, resultado);
        }

        [TestMethod]
        public void TestResta()
        {
            // Arrange
            decimal numero1 = 10;
            decimal numero2 = 5;

            // Act
            decimal resultado = Calculadora.restar(numero1, numero2);

            // Assert
            decimal valorEsperado = 5;
            Assert.AreEqual(valorEsperado, resultado);
        }

        [TestMethod]
        public void TestDivision()
        {
            // Arrange
            decimal numero1 = 10;
            decimal numero2 = 5;

            // Act
            decimal resultado = Calculadora.dividir(numero1, numero2);

            // Assert
            decimal valorEsperado = 2;
            Assert.AreEqual(valorEsperado, resultado);
        }
    }
}
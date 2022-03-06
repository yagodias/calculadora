using Calculadora.Application.Calculos;
using NUnit.Framework;

namespace Calculadora.Testes.Application
{
    internal class EquacaoTestes
    {
        [Test]
        [TestCase(4, -3, 1, -1, -12)]
        [TestCase(3, -3, 3, 0, -27)]
        public void Deve_Calcular(double Expected_X1, double Expected_X2, double a, double b, double c)
        {
            // Arrange
            var eq = new Equacao();

            // Act
            var result = eq.Calcular(a, b, c);

            // Assert
            Assert.AreEqual(Expected_X1, result.X1);
            Assert.AreEqual(Expected_X2, result.X2);
        }
    }
}

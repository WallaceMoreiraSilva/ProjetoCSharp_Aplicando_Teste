using Calculos;
using Xunit;

namespace CalculosTeste
{
    public class CalculoUnitTest
    {
        [Fact]
        public void Somar_DoisDouble_RetornarDouble()
        {
            //Arrange
            var num1 = 2.9;
            var num2 = 3.1;
            var valorEsperado = 6;

            //Act
            var soma = Calculo.Somar(num1, num2);

            //Assert
            Assert.Equal(valorEsperado, soma) ;
        }
    }
}

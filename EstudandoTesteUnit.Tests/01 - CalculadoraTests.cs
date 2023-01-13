using EstudandoTesteUnidade;
using System;

namespace EstudandoTesteUnit.Tests
{
    public class CalculadoraTests
    {

        [Fact]
        public void Calculadora_Somar_RetonarValorSoma() {

            //Arrange
            var calculadora = new Calculadora();

            //act
           var resultado = calculadora.Somar(1, 2);

            //Assert
            Assert.Equal(3, resultado);
        }

        [Fact]
        public void Calculadora_Dividir_RetonarValorDivisao()
        {
            //Arrange
            var calculadora = new Calculadora();

            //act
            var resultado = calculadora.Dividir(2, 2);

            //Assert
            Assert.Equal(1, resultado);
        }


        [Theory]
        [InlineData(1,1,2)]
        [InlineData(2, 2, 4)]
        [InlineData(3, 3, 6)]
        [InlineData(1, 5, 6)]
        public void Calculadora_Somar_RetornarValoreSomaCorretos(double valor1, double valor2, double total) 
        {

            //Arrange
            var calculadora = new Calculadora();

            //act
            var resultado = calculadora.Somar(valor1, valor2);

            //Assert
            Assert.Equal(total, resultado);
        }
    }
}

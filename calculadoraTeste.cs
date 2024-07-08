using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace projeto_Xunit
{
    public class calculadoraTeste
    {
        [Fact]
        public void TestarSoma()
        {
            double resultado = calculadora.Somar(4, 10);
            Assert.Equal(14, resultado);
        }
        [Fact]
        public void Testarsubtrair()
        {
            double resultado = calculadora.Subtrair(2, 10);
            Assert.Equal(8, resultado);
        }
        [Fact]
        public void TestarMultiplicar()
        {
            double resultado = calculadora.Multiplicar(2, 10);
            Assert.Equal(double.PositiveInfinity, resultado);
        }
        [Fact]
        public void TestarDividir()
        {
            double resultado = calculadora.Dividir(2, 10);
            Assert.Equal(5, resultado);
        }

    }
}


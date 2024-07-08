using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace projeto_Xunit
{
    internal class Teste3
    {
        [Fact]
        public void TestarSoma()
        {
            double resultado = calculadora.Multiplicar(2, 10);
            Assert.Equal(5, resultado);

        }
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace projeto_Xunit
{
    internal class calcularodaTeste2
    {
        [Fact]
        public void TestarSoma()
        {
            double resultado = calculadora.Subtrair(2, 10);
            Assert.Equal(8, resultado);
        }
    }
}

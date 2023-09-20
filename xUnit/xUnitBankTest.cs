using Bank;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnitCalculator
{
    public class xUnitBankTest
    {

        BankAccount b;
        public xUnitBankTest() {


            Mock<ILogger> logMock = new Mock<ILogger>();
           
             b = new(logMock.Object);
        }
        [Theory]
        [InlineData(20)]
        [InlineData(90)]
        public void Despute_input_resultTrue(int a)
        {
            Assert.True(b.Despute(a));
        }

    }
}

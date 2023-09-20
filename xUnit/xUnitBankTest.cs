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
        public xUnitBankTest() {


            Mock logMock = new Mock<ILogger>();
            ILogger m = logMock.Object;
            BankAccount b = new(m);
        }
        [Theory]
        [InlineData(20)]
        public void Despute_input_resultTrue(int a)
        {

        }

    }
}

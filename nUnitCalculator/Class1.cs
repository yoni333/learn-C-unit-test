using calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nUnitCalculator
{
    [TestFixture]
    internal class CustomerTest
    {
        [Test]
        public void FullName_InputStrings_resultConcat()
        {
            Customer c = new();
            string res = c.fullName("Yoni", "Yehezkel");
            Assert.That(res, Is.EqualTo("Hello ,Yoni Yehezkel"));
            Assert.That(!string.IsNullOrEmpty(res));
            Assert.That(res, Does.Contain("Yoni"));
            Assert.That(res, Does.Match("Hello ,[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]"));
        }
    }
}

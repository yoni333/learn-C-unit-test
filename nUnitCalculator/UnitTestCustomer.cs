using calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nUnitCalculator
{
    [TestFixture]
    public class CustomerTest
    {
        [Test]
        public void FullName_InputStrings_resultConcat()
        {
            //arrange
            Customer c = new();
            // act
            string res = c.fullName("Yoni", "Yehezkel");
            // assert
            Assert.That(res, Is.EqualTo("Hello ,Yoni Yehezkel")); //this is constrain model
            Assert.AreEqual(res, "Hello ,Yoni Yehezkel");
            Assert.That(!string.IsNullOrEmpty(res));
            Assert.That(res, Does.Contain("Yoni"));
            Assert.That(res, Does.Contain("yoni").IgnoreCase);
            Assert.That(res, Does.Match("Hello ,[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]"));
        }
        [Test]
        public void greetMessage_isNull()
        {
            Customer c = new();
            Assert.IsNull(c.greetMessage);
        }
    }
}

using calculator;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnitCalculator
{
   
    public class xCustomerTest
    {
        [Fact]
        public void FullName_InputStrings_resultConcat()
        {
            //arrange
            Customer c = new();
            // act
            string res = c.fullName("Yoni", "Yehezkel");
            // assert
            Assert.IsType<string>(res);
            Assert.Equal("Hello ,Yoni Yehezkel" ,res);
            Assert.NotNull(res);
            Assert.Contains("Yoni" ,res);
            Assert.Contains("yoni" ,res.ToLower());
            Assert.Matches("Hello ,[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]",res);
           
        }
        [Fact]
        public void greetMessage_isNull()
        {
            Customer c = new();
            Assert.Null(c.greetMessage);
        }
        [Fact]
        public void fullNameRequired_inputMissingName_resultThrowExeption()
        {
            Customer c = new();
           ArgumentNullException res = Assert.Throws<ArgumentNullException>(() => c.fullNameRequired("", "roni")) ;
            string expectedMessage = "Value cannot be null. (Parameter 'name is empty')";
                Assert.Equal(expectedMessage,res.Message);
        }
    }

    public class xCustomerTestDI
    {
        Customer c;
        public xCustomerTestDI()
        {
            //arrange

            c = new();
        }
        [Fact]
        public void FullName_InputStrings_resultConcat()
        {
            
            // act
            string res = c.fullName("Yoni", "Yehezkel");
            // assert
            Assert.IsType<string>(res);
            Assert.Equal("Hello ,Yoni Yehezkel", res);
            Assert.NotNull(res);
            Assert.Contains("Yoni", res);
            Assert.Contains("yoni", res.ToLower());
            Assert.Matches("Hello ,[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]", res);

        }
        [Fact]
        public void greetMessage_isNull()
        {
            c.FeelGreetMessage("aa");
            Assert.Null(c.greetMessage);
        }
        [Fact]
        public void fullNameRequired_inputMissingName_resultThrowExeption()
        {
           
            ArgumentNullException res = Assert.Throws<ArgumentNullException>(() => c.fullNameRequired("", "roni"));
            string expectedMessage = "Value cannot be null. (Parameter 'name is empty')";
            Assert.Equal(expectedMessage, res.Message);
        }
    }
}

using calculator;

namespace xUnitCalculator
{
    
    public class xTestCalculator
    {
       
        public  xTestCalculator()
        {
        }

        [Theory]
        [InlineData(2,4, 6)]
        public void AddNumbers_InputTwoNumbers_GetCorrectResult(int a,int b ,int expextdResult)
        {
            Calculator c = new();
           int res =   c.AddNumbers(a, b);
            Assert.Equal(expextdResult,res);
        }
        [Theory]
        [InlineData(2.6, 4.2,6.8)]
        [InlineData(4.2,2.6,6.8)]
        public void AddNumbersDouble_InputTwoNumbers_GetCorrectResult(double a, double b,double expextdResult)
        {
            Calculator c = new();
            double  res = c.AddNumbers(a, b);
             Assert.Equal(expextdResult,res,0);
        }
        [Fact]
        public void OddnumbersRanger_InputMinAndMax_returnValidRange()
        {
            // arrenge
            Calculator c = new();
            List<int> numbersExpected = new List<int>() { 10, 12, 14, 16, 18 };
            //acr
            var  res = c.GetOddNumbers(10, 20);
            //assert
            Assert.Equal(numbersExpected,res);
            Assert.Contains(12,res);
            Assert.NotEmpty(res);
            Assert.Equal(5, res.Count);
            Assert.DoesNotContain(6 ,res);
            Assert.Equal(res.OrderBy(u=>u),numbersExpected);
          //  Assert.That(res, Is.Unique);  -- not have this . insert uniqe data and use Equel
        }
       
    }
}
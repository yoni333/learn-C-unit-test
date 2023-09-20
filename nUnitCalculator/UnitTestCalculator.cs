using calculator;

namespace nUnitCalculator
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(2,4,ExpectedResult  = 6)]
        public int AddNumbers_InputTwoNumbers_GetCorrectResult(int a,int b )
        {
            Calculator c = new();
           return  c.AddNumbers(a, b);
           // Assert.That(res, Is.EqualTo(10));
        }
        [Test]
        [TestCase(2.6, 4.2)]
        [TestCase(4.2,2.6)]
        public void AddNumbersDouble_InputTwoNumbers_GetCorrectResult(double a, double b)
        {
            Calculator c = new();
            double  res = c.AddNumbers(a, b);
             Assert.That(res, Is.EqualTo(6.8).Within(0.1));
        }
        [Test]
        public void OddnumbersRanger_InputMinAndMax_returnValidRange()
        {
            // arrenge
            Calculator c = new();
            List<int> numbersExpected = new List<int>() { 10, 12, 14, 16, 18 };
            //acr
            var  res = c.GetOddNumbers(10, 20);
            //assert
            Assert.That(res,Is.EquivalentTo(numbersExpected));
        }
       
    }
}
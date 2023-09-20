using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public class Calculator
    {
        public List<int> oddNumbers = new List<int>();
        public int AddNumbers(int a, int b)
        {
            return a + b;
        }

        public double AddNumbers(double  a, double b)
        {
            return a + b;
        }

        public List<int> GetOddNumbers(int min, int max)
        {
            for (int i = min;i < max; i++)
            {
                if (i%2 == 0)
                {
                   oddNumbers.Add(i);
                }
            }
            return oddNumbers;

        }

    }
}

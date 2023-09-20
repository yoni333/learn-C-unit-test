using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public class Customer
    {
        public string? greetMessage { get; set; }    
        public string fullName(string name , string lastName)
        {
            return $"Hello ,{name} {lastName}";
        }
    }
}

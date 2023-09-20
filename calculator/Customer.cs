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
            string st = $"Hello ,{name} {lastName}";
            greetMessage = st;
            return st ;
        }
        public string fullNameRequired(string name, string lastName)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("name is empty");
            }
            return $"Hello ,{name} {lastName}";
        }
        public void FeelGreetMessage(string GreetMessage)
        {
            greetMessage = GreetMessage;
        }
    }
}

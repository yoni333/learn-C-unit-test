using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class BankAccount

    {
        ILogger logger;
        public int amount  = 0;
        public BankAccount(ILogger Logger) {

           
            logger = Logger;
        }
        public bool Despute(int a)
        {
            if (amount - a > 0)
            {
                amount -= a ;
                logger.Info(amount.ToString());
                return true;
            }
            return false;
        }
       
    }
    public interface ILogger
    {
         void Info(string message);
   //     public string Info(string message, Exception exception);
    }
    public class Logger :ILogger { 
        
        public Logger() { }

        public void Info(string message)
        {
           Console.WriteLine(message);
        }

        public string Info(string message, Exception exception)
        {
            string st = message + " " + exception.Message;
            Console.WriteLine(st);
            return st;
        }
    }
}

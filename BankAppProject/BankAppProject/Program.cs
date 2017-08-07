using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int account = 1000;
            string newBalance;
            int withDraw = 1;
            //int balance = 
            //int sum = total;
            //x = 5;
            //string deposit = newBalance;

            //int.TryParse(newBalance, out x);
            //Console.WriteLine($"In the main method x = {x}");

            //DisplayValueParameters(x);
            //Console.WriteLine($"In the main method the value of x is now {x}");

            //DisplayNewValue(ref x);
            //Console.WriteLine($"The value of exiting x is now {x}");

            //DisplaySecondValue(ref x);
            //Console.WriteLine($"The value of z is now {x}");
            //newBalance(ref account);

            //Console.ReadLine();
        }
        private static void balance(ref int account)
        {

            Console.WriteLine($"Your current balance is {account}");
           
            Console.WriteLine($"How may I help you, you can 1.withDraw \n 2. make a deposit \n 3.check your balance");
            //Console.WriteLine($"Your {newBalance} is");
                



            if (1 == 1)
            {
                Console.WriteLine($"How much would you like to deposit? )");

            }
            if (2 == 2)
            {
                Console.WriteLine($"Your account balance is {account}");
                Console.ReadLine();

            }
            else
            Console.ReadLine();
              
                
               
        }
        
    }
}


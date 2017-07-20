// This program greets the user
// and multiplies two entered values
using System;
using static System.Console;
class DebugTwo2
{
   static void Main()
   {
      string name;
      string firstString, secondString;

      int first, second, product;
      
      WriteLine("Enter your name");
      name = ReadLine();
      WriteLine("Hello {0}! Enter an integer", name);
      firstString = ReadLine();
      int.TryParse(firstString, out first);
      WriteLine("Enter another integer");
      secondString = ReadLine();
      int.TryParse(secondString, out second);
      product = first * second;
      
      WriteLine($"Thank you {name}. The product of {first} and {second} is {product}",
	  name, first, second, product);
   }
}

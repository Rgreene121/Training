// Program averages four numbers
using static System.Console;
class DebugSix02
{
   public static void SixTwo()
   {
      int[] numbers = {12, 15, 22, 88}; // total = 137
      int x;
      double average;
      double total = 0;
      Write("What is the average of the numbers array..");
      for(x = 0; x < numbers.Length; ++x)
         Write("{0, 6}", numbers[x]);
      WriteLine();      
      for(x = 0; x < numbers.Length; ++x)
      {
         total = total + numbers[x];
      }   
      average = total / numbers.Length;
      Write("The average is {0}", average);
        ReadLine();
   }
}
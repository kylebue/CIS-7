using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
  class Assignment11
  {
    //static System.Diagnostics.Stopwatch watch = System.Diagnostics.Stopwatch.StartNew();
    //static System.Diagnostics.Stopwatch bruteWatch = System.Diagnostics.Stopwatch.StartNew();
    
    static void Main(string[] args)
    {
      AskForNums();
    }

    static void AskForNums()
    {
      string userNum1 = "";

      while (userNum1 != "q")
      {
        userNum1 = "";
        string userNum2 = "";
        long num1 = 0;
        long num2 = 0;
        bool isValidResponse = false;
        long result = 0;
        long resultEuclid = 0;

        Console.WriteLine("Enter a number (press 'q' to quit): ");
        userNum1 = Console.ReadLine();

        if (long.TryParse(userNum1, out num1))
        {
          while (!isValidResponse)
          {
            Console.WriteLine("\nEnter another number: ");
            userNum2 = Console.ReadLine();

            if (long.TryParse(userNum2, out num2))
            {
              isValidResponse = true;

              System.Diagnostics.Stopwatch bruteWatch = System.Diagnostics.Stopwatch.StartNew();
              result = FindGCD(num1, num2);
              bruteWatch.Stop();
              
              System.Diagnostics.Stopwatch euclidWatch = System.Diagnostics.Stopwatch.StartNew();
              resultEuclid = FindGCDEuclid(num1, num2);
              euclidWatch.Stop();
              
              Console.WriteLine("\nBrute force method took: " + bruteWatch.ElapsedMilliseconds + " milliseconds.\n");
              Console.WriteLine("Euclid method took: " + euclidWatch.ElapsedMilliseconds + " milliseconds.");
              
              Console.WriteLine("\nThe Greatest Common Divisor by brute force is: " + result + "\n");
              Console.WriteLine("The Greatest Common Divisor by Euclid is: " + resultEuclid + "\n");
            }
            else
            {
              Console.WriteLine("\nInvalid response. Try again.\n");
            }
          }
        }
        else if (userNum1 == "q")
        {
          Console.WriteLine("\nGoodbye!\n");
          break;
        }
        else
        {
          Console.WriteLine("\nInvalid response. Try again.\n");
        }
      }
    }

    
    static long FindGCD(long num1, long num2)
    {
      long minNum = 0;
      long GCD = 0;
      minNum = Math.Min(num1, num2);
      
      for (long i = minNum + 1; i > 0; i--)
      {
        if (num1 % i == 0 && num2 % i == 0)
        {
          GCD = i;
          break;
        }
      }
      return GCD;
    }
    
    
    
    static long FindGCDEuclid(long num1, long num2)
    {
      if (num2 == 0)
      {
        return num1;
      }
      return FindGCDEuclid(num2, num1 % num2);
    }
    
  }
}
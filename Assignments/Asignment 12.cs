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
        
        int i = 0;

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
              result = FindGCD(num1, num2, i);
              bruteWatch.Stop();
              
              System.Diagnostics.Stopwatch euclidWatch = System.Diagnostics.Stopwatch.StartNew();
              resultEuclid = FindGCDEuclid(num1, num2, i);
              euclidWatch.Stop();
              
              Console.WriteLine("\nBrute force method took: " + bruteWatch.Elapsed.TotalMilliseconds * 1000000 + " nanoseconds.\n");
              Console.WriteLine("Euclid method took: " + euclidWatch.Elapsed.TotalMilliseconds * 1000000 + " nanoseconds.");
              
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

    
    static long FindGCD(long num1, long num2, int tick)
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
    
    static long FindGCDEuclid(long num1, long num2, int tick)
    {
      
      if (num2 == 0)
      {
        Console.WriteLine(tick);
        return num1;
      }
      tick++;
      return FindGCDEuclid(num2, num1 % num2, tick);
    }
    
  }
}

###OUTPUT###
Enter a number (press 'q' to quit): 
 864

Enter another number: 
 68464

Brute force method took: 142200 nanoseconds.

Euclid method took: 1247800 nanoseconds.

The Greatest Common Divisor by brute force is: 16

The Greatest Common Divisor by Euclid is: 16

Enter a number (press 'q' to quit): 
 1234567890

Enter another number: 
 9876543210

Brute force method took: 17208903300 nanoseconds.

Euclid method took: 253800 nanoseconds.

The Greatest Common Divisor by brute force is: 90

The Greatest Common Divisor by Euclid is: 90

Enter a number (press 'q' to quit): 
 q

Goodbye!
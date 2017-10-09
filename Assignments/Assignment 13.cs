using System;
using System.Math;

namespace HelpMe
{
  class Hello 
  {
    static void Main() 
    {
      double n = 3;
      string a = "Start";
      string b = "End";
      string c = "Aux";
      
      Move(n, a, b, c);
      Console.WriteLine(Formula(n));
    }
    
    static void Move(double n, string a, string b, string c)
    {
      if (n > 0)
      {
        Move(n-1, a, c, b);
        
        Console.WriteLine("Move disk from " + a + " to " + b);
        Move(n-1, c, b, a);
      }
    }
    
    static double Formula(double n)
    {
      return (Math.Pow(2, n)) - 1;
    }
  }
}

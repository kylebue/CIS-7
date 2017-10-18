using System;
using System.Collections;
using System.Collections.Generic;

public class Fact
{
  static void Main()
  {
    Stack<double> stack = new Stack<double>();
    string userNum = "";
    double num = 0;
    
    Console.WriteLine("Enter a number: ");
    userNum = Console.ReadLine();
    if (double.TryParse(userNum, out num))
    {
      Console.WriteLine(Factorial(num, stack));
    }
  }
  
  static double Factorial(double n, Stack<double> numStack)
  {
    numStack.Push(n);
    
    if (n <= 1)
    {
      Console.WriteLine("Fact " + n);
      numStack.Pop();
      return 1;
    }
    
    double x = n * Factorial(n-1, numStack);
    Console.WriteLine("Fact " + (n-1));
    numStack.Pop();
    return x;
  }
}
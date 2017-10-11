using System;
using System.Math;
using System.Collections.Generic;

namespace HelpMe
{
  public class Tower
  {
    public string name;
    public List<double> disks = new List<double>();
    public Tower(string name, List<double> disks)
    {
      name = this.name;
      disks = this.disks;
    }
    
    public void print()
    {
      
    }
  }
  
  class Hello 
  {
    static void Main() 
    {
      double n = 2;
      string name = "";
      List<double> disks = new List<double>();
      Tower startTower = new Tower(name, disks);
      Tower endTower = new Tower(name, disks);
      Tower auxTower = new Tower(name, disks);

      startTower.name = "Start";
      endTower.name = "End";
      auxTower.name = "Spare";
      
      for (int i = 1; i <= n; i++)
      {
        startTower.disks.Add(i);
      }
      
      startTower.print();
      endTower.print();
      auxTower.print();
      
      Move(n, startTower, endTower, auxTower);
      //Console.WriteLine(Formula(n));
    }
    
    static void Move(double n, Tower a, Tower b, Tower c)
    {
      if (n > 0)
      {
        Move(n-1, a, c, b);
        
        Console.WriteLine("Move disk from " + a.name + " to " + b.name);

        a.print();
        b.print();
        c.print();
        
        Move(n-1, c, b, a);
      }
    }
    
    static double Formula(double n)
    {
      return (Math.Pow(2, n)) - 1;
    }
  }
}

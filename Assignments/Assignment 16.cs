using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class Notation
{
  static void Main(string[] args)
  {
    List<string> setA = new List<string>();
    List<string> setB = new List<string>();
    List<string> union = new List<string>();
    List<string> intersect = new List<string>();
    List<string> minusAB = new List<string>();
    List<string> minusBA = new List<string>();
    List<string> crossAB = new List<string>();
    List<string> powersetA = new List<string>();
    List<string> powersetB = new List<string>();
    DisplaySets(setA, setB, union, intersect, minusAB, minusBA, crossAB, powersetA, powersetB);
    /*for (int i = 0; i < setA.Length; i++)
    {
      Console.Write(setA[i].ToString() + "} ");
    }*/
    
    
  }
  
  static void DisplaySets(List<string> setA, List<string> setB, List<string> union, List<string> intersect, List<string> minusAB, List<string> minusBA, List<string> crossAB, List<string> powersetA, List<string> powersetB)
  {
    Console.Clear();
    //string[] setA = new string[0];
    //string[] setB = new string[0];
    //int choice = 0;
    
    Console.Write("Set A = {");
    for (int i = 0; i < setA.Count; i++)
    {
      if (i != setA.Count - 1)
      {
        Console.Write(setA[i] + ", ");
      }
      else
      {
        Console.Write(setA[i]);
      }
    }
    Console.WriteLine("} " + "|" + setA.Count + "|");
    Console.Write("Set B = {");
    for (int i = 0; i < setB.Count; i++)
    {
      if (i != setB.Count - 1)
      {
        Console.Write(setB[i] + ", ");
      }
      else
      {
        Console.Write(setB[i]);
      }
    }
    Console.WriteLine("} " + "|" + setB.Count + "|");
    
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("(1) Add item to Set A");
    Console.WriteLine("(2) Add item to Set B");
    Console.WriteLine("(3) A u B");
    Console.WriteLine("(4) A n B");
    Console.WriteLine("(5) A - B");
    Console.WriteLine("(6) B - A");
    Console.WriteLine("(7) A x B");
    Console.WriteLine("(8) Powerset A");
    Console.WriteLine("(9) Powerset B");
    Console.WriteLine("(10) Exit");
    
    MakeChoice(setA, setB, union, intersect, minusAB, minusBA, crossAB, powersetA, powersetB);
  }
  
  static void MakeChoice(List<string> setA, List<string> setB, List<string> union, List<string> intersect, List<string> minusAB, List<string> minusBA, List<string> crossAB, List<string> powersetA, List<string> powersetB)
  {
    int choice = 0;
    choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
      case 1:
        setA = AddToA(setA);
        DisplaySets(setA, setB, union, intersect, minusAB, minusBA, crossAB, powersetA, powersetB);
        break;
      case 2:
        setB = AddToB(setB);
        DisplaySets(setA, setB, union, intersect, minusAB, minusBA, crossAB, powersetA, powersetB);
        break;
      case 3:
        union = MakeUnion(setA, setB);
        Console.Write("\nA u B = {");
        WriteAnswer(union);
        DisplaySets(setA, setB, union, intersect, minusAB, minusBA, crossAB, powersetA, powersetB);
        break;
      case 4:
        intersect = MakeIntersect(setA, setB);
        Console.Write("\nA n B = {");
        WriteAnswer(intersect);
        DisplaySets(setA, setB, union, intersect, minusAB, minusBA, crossAB, powersetA, powersetB);
        break;
      case 5:
        minusAB = MinusAB(setA, setB);
        Console.Write("\nA - B = {");
        WriteAnswer(minusAB);
        DisplaySets(setA, setB, union, intersect, minusAB, minusBA, crossAB, powersetA, powersetB);
        break;
      case 10:
        break;
    }
  }
  
  static List<string> AddToA(List<string> setA)
  {
    string userInput = "";
    Console.WriteLine("What would you like to add to Set A?");
    userInput = Console.ReadLine();
    setA.Add(userInput);
    return setA;
  }
  
  static List<string> AddToB(List<string> setB)
  {
    string userInput = "";
    Console.WriteLine("What would you like to add to Set B?");
    userInput = Console.ReadLine();
    setB.Add(userInput);
    return setB;
  }
  
  static List<string> MakeUnion(List<string> setA, List<string> setB)
  {
    List<string> union = new List<string>();
    union = Enumerable.Union(setA, setB).ToList();
    
    return union;
  }
  
  static List<string> MakeIntersect(List<string> setA, List<string> setB)
  {
    List<string> intersect = new List<string>();
    intersect = Enumerable.Intersect(setA, setB).ToList();
    
    return intersect;
  }
  
  static List<string> MinusAB(List<string> setA, List<string> setB)
  {
    List<string> minusAB = new List<string>();
    
    return minusAB;
  }
  
  static void WriteAnswer(List<string> answer)
  {
    for (int i = 0; i < answer.Count; i++)
    {
      if (i != answer.Count - 1)
      {
        Console.Write(answer[i] + ", ");
      }
      else
      {
        Console.Write(answer[i]);
      }
    }
    Console.WriteLine("}\n");
  }
}
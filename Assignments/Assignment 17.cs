using System;
using System.Collections;
using System.Collections.Generic;

class Graph
{
  static void Main()
  {
    Display();
  }
  
  static void Display()
  {
    bool repeat = true;
    string userInput = "";
    int userNum = 0;
    List<List<int>> matrix = new List<List<int>>();
    
    do
    {
      Console.WriteLine("What would you like to do?");
      Console.WriteLine("(1) Add a vertex");
      Console.WriteLine("(2) Add an edge");
      Console.WriteLine("(3) Display info on the graph");
      Console.WriteLine("(0) Exit");
      
      userInput = Console.ReadLine();
      Console.WriteLine("");
      
      userNum = int.Parse(userInput);
      
      if (userNum == 1)
      {
        AddVertex(matrix);
      }
      else if (userNum == 2)
      {
        AddEdge();
      }
      else if (userNum == 3)
      {
        DisplayGraph();
      }
      else if (userNum == 0)
      {
        repeat = false;
        break;
      }
      else
      {
        Console.WriteLine("Invalid response\n");
      }
    } while(repeat);
  }
  
  static void AddVertex(List<List<int>> matrix)
  {
    matrix.Add(new List<int>());
    foreach (var row in matrix)
    {
      while (row.Count < matrix.Count)
      {
        row.Add(0);
      }
    }
  }
  static void AddEdge()
  {
    
  }
  static void HighestDegree()
  {
    
  }
  static void FindIsolatedVertices()
  {
    
  }
  static void FindLoops()
  {
    
  }
  static bool IsConnected()
  {
    return false;
  }
  static bool IsComplete()
  {
    return false;
  }
  static void DisplayGraph()
  {
    Console.WriteLine("Vertex with the highest degree: ");
    Console.WriteLine("Isolated vertices: ");
    Console.WriteLine("");
  }
}
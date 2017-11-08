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
    List<int> directedGraph = new List<int>();
    int numEdges = 0;
    
    //Console.WriteLine("Graph currently contains " + numVertices.Count + " vertices and " + numEdges + " edges\n");
    
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
        directedGraph = AddVertex(directedGraph);
      }
      else if (userNum == 2)
      {
        AddEdge(directedGraph);
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
  
  static List<int> AddVertex(List<int> graph)
  {
    Vertex vertex = new Vertex();
    Console.WriteLine("Enter number of vertex:");
    vertex.name = Console.ReadLine();
    Console.WriteLine("");
    
    graph.Add(int.Parse(vertex.name));
    return graph;
  }
  static void AddEdge(List<int> graph)
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
    // Display graph info
  }
}
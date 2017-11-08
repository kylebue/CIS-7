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
    int numVertices = 0;
    int numEdges = 0;
    
    do
    {
      Console.WriteLine("Graph currently contains " + numVertices + " vertices and " + numEdges + " edges\n");
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
        numVertices = AddVertex(numVertices);
      }
      else if (userNum == 2)
      {
        numEdges = AddEdge(numEdges);
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
  
  static int AddVertex(int vertices)
  {
    vertices++;
    return vertices;
  }
  static int AddEdge(int edges)
  {
    edges++;
    return edges;
  }
  static void DisplayGraph()
  {
    // Display graph info
  }
}
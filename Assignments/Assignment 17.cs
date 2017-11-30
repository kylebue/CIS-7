using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

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
      
      if (int.TryParse(userInput, out userNum))
      {
        if (userNum == 1)
        {
          AddVertex(matrix);
        }
        else if (userNum == 2)
        {
          AddEdge(matrix);
        }
        else if (userNum == 3)
        {
          DisplayGraph(matrix);
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
      }
      else
      {
        Console.WriteLine("Invalid response\n");
      }
    } while(repeat);
  }
  
  static void AddVertex(List<List<int>> matrix)
  {
    var newList = new List<int>();
    var columns = matrix.Any() ? matrix.Count : 0;
    
    for (int i = 0; i < columns; i++)
    {
      newList.Add(0);
    }
    
    matrix.Add(newList);
    foreach (var row in matrix)
    {
      row.Add(0);
    }
  }
  static void AddEdge(List<List<int>> matrix)
  {
    string choice1 = "";
    string choice2 = "";
    int num1 = 0;
    int num2 = 0;
    
    Console.WriteLine("Choose the first value:");
    choice1 = Console.ReadLine();
    if (int.TryParse(choice1, out num1))
    {
      Console.WriteLine("Choose the second value:");
      choice2 = Console.ReadLine();
      Console.WriteLine("");
      if (int.TryParse(choice2, out num2))
      {
        matrix[num1][num2]++;
        matrix[num2][num1]++;
      }
      else
      {
        Console.WriteLine("Invalid choice\n");
      }  
    }
    else
    {
      Console.WriteLine("\nInvalid choice\n");
    }  
  }
  static int HighestDegree(List<List<int>> matrix)
  {
    int highest = 0;
    int count = 0;
    foreach (var row in matrix)
    {
      count = row.Sum(m => m);
      
      if (count > highest)
      {
        highest = count;
      }
    }
    return highest;
  }
  static int FindIsolatedVertices(List<List<int>> matrix)
  {
    int numIsolated = 0;
    int count = 0;
    foreach (var row in matrix)
    {
      count = row.Sum(m => m);
      
      if (count == 0)
      {
        numIsolated++;
      }
    }
    
    return numIsolated;
  }
  static int FindLoops(List<List<int>> matrix)
  {
    int numLoops = 0;
    int count = 0;
    foreach (var row in matrix)
    {
      count = row.Sum(m => m);
      
      if (count > 1)
      {
        numLoops++;
      }
    }
    
    return numLoops;
  }
  static bool IsComplete(List<List<int>> matrix)
  {
    bool zeros = false;
    bool ones = false;
    int numZeros = 0;
    int numOnes = 0;
    int count = 0;
    
    for (int i = 0; i < matrix.Count; i++)
    {
      for (int j = 0; j < matrix[i].Count; j++)
      {
        count++;
        if (i == j)
        {
          if (matrix[i][j] == 0)
          {
            numZeros++;
          }
        }
        else if (i != j)
        {
          if (matrix[i][j] == 1)
          {
            numOnes++;
          }
        }
      }
    }

    if (numZeros == matrix.Count)
    {
      zeros = true;
    }
    if (numOnes + numZeros == count)
    {
      ones = true;
    }
    
    if (zeros && ones)
    {
      return true;
    }
    else
    {
      return false;
    }
    return false;
  }
  static void DisplayGraph(List<List<int>> matrix)
  {
    int highestDegree = 0;
    int isolated = 0;
    int loops = 0;
    bool isComplete = false;
    highestDegree = HighestDegree(matrix);
    isolated = FindIsolatedVertices(matrix);
    loops = FindLoops(matrix);
    isComplete = IsComplete(matrix);
    Console.WriteLine("Vertex with the highest degree: " + highestDegree);
    Console.WriteLine("Isolated vertices: " + isolated);
    Console.WriteLine("Number of loops: " + loops);
    if (isolated == 0)
    {
      Console.WriteLine("Graph is connected");
    }
    else
    {
      Console.WriteLine("Graph is NOT connected");
    }
    if (isComplete)
    {
      Console.WriteLine("Graph is complete");
    }
    else
    {
      Console.WriteLine("Graph is NOT complete");
    }
    Console.WriteLine("");
    
    for (int i = 0; i < matrix.Count; i++)
    {
      for (int j = 0; j < matrix[i].Count; j++)
      {
        Console.Write(matrix[i][j]);
      }
      Console.WriteLine("");
    }
    Console.WriteLine("");
  }
}
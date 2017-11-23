using System;
using System.Collections;
using System.Collections.Generic;

class Tree
{
  static string userInput = "";
  static int input = 0;
  static Node root = new Node();
  static int numNodes = 0;
  static List<Node> nodes = new List<Node>();
  static int currentTreeHeight = 0;
  
  static void Main()
  {
    Console.WriteLine("Welcome to the treehouse!\n");
    root.name = "A";
    nodes.Add(root);
    
    
    Intro();
  }
  
  public static void Intro()
  {
    numNodes = nodes.Count;
    for (int i = 0; i < nodes.Count; i++)
    {
      if (currentTreeHeight < nodes[i].depth)
      {
        currentTreeHeight = nodes[i].depth;
      }
    }
    
    DisplayTreeInfo();
    
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("1. Add a left child to a node");
    Console.WriteLine("2. Add a right child to a node");
    Console.WriteLine("3. Exit");
    
    userInput = Console.ReadLine();
    if (int.TryParse(userInput, out input))
    {
      switch (input)
      {
        case 1:
        AddLeftChild();
        break;
        case 2:
        AddRightChild();
        break;
        case 3:
        Console.WriteLine("\nGoodbye!");
        break;
        default:
        Console.WriteLine("Invalid choice");
        break;
      }
    }
    else
    {
      Console.WriteLine("\nInvalid choice");
    }
  }
  
  public static void AddLeftChild()
  {
    string userChoice = "";
    string nodeName = "";
    
    Console.WriteLine("\nWhich node would you like to attach to?");
    for (int i = 0; i < nodes.Count; i++)
    {
      if (nodes.Count == 1)
      {
        Console.Write(nodes[i].name + "\n");;
      }
      else if (i == nodes.Count - 1)
      {
        Console.Write("or " + nodes[i].name + "\n");
      }
      else
      {
        Console.Write(nodes[i].name + ", ");
      }
    }
    userChoice = Console.ReadLine().ToUpper();
    for (int i = 0; i < nodes.Count; i++)
    {
      if (userChoice == nodes[i].name)
      {
        if (!nodes[i].hasLeftChild)
        {
          Console.WriteLine("\nWhat would you like to name this node?");
          nodeName = Console.ReadLine().ToUpper();
          Console.WriteLine("");
          Node leftNode = new Node();
          leftNode.name = nodeName;
          leftNode.depth = nodes[i].depth + 1;
          nodes.Add(leftNode);
          nodes[i].leftChild = leftNode;
          nodes[i].hasLeftChild = true;
          Intro();
        }
        else
        {
          Console.WriteLine("\nNode " + nodes[i].name + " already has a left child!");
        }
      }
    }
  }
  
  public static void AddRightChild()
  {
    string userChoice = "";
    string nodeName = "";
    
    Console.WriteLine("\nWhich node would you like to attach to?");
    for (int i = 0; i < nodes.Count; i++)
    {
      if (nodes.Count == 1)
      {
        Console.Write(nodes[i].name + "\n");;
      }
      else if (i == nodes.Count - 1)
      {
        Console.Write("or " + nodes[i].name + "\n");
      }
      else
      {
        Console.Write(nodes[i].name + ", ");
      }
    }
    userChoice = Console.ReadLine().ToUpper();
    for (int i = 0; i < nodes.Count; i++)
    {
      if (userChoice == nodes[i].name)
      {
        if (!nodes[i].hasRightChild)
        {
          Console.WriteLine("\nWhat would you like to name this node?");
          nodeName = Console.ReadLine().ToUpper();
          Console.WriteLine("");
          Node rightNode = new Node();
          rightNode.name = nodeName;
          rightNode.depth = nodes[i].depth + 1;
          nodes.Add(rightNode);
          nodes[i].rightChild = rightNode;
          nodes[i].hasRightChild = true;
          Intro();
        }
        else
        {
          Console.WriteLine("\nNode " + nodes[i].name + " already has a right child!");
        }
      }
    }
  }
  
  public static void DisplayTreeInfo()
  {
    Console.WriteLine("Current number of nodes: " + numNodes);
    Console.WriteLine("Current tree height: " + currentTreeHeight);
    if (CheckFull())
    {
      Console.WriteLine("Tree is full");
    }
    else
    {
      Console.WriteLine("Tree is not full");
    }
    if (CheckComplete(0))
    {
      Console.WriteLine("Tree is complete");
    }
    else
    {
      Console.WriteLine("Tree is not complete");
    }
    Console.WriteLine("Preorder traversal:");
    Preorder(root);
    Console.WriteLine("Inorder traversal:");
    Inorder(root);
    Console.WriteLine("Postorder traversal:");
    Postorder(root);
    Console.WriteLine("");
  }
  
  public static void Preorder(Node n)
  {
    Console.WriteLine(n.name);
    if (n.hasLeftChild)
    {
      Preorder(n.leftChild);
    }
    if (n.hasRightChild)
    {
      Preorder(n.rightChild);
    }
  }
  
  public static void Inorder(Node n)
  {
    if (n.hasLeftChild)
    {
      Inorder(n.leftChild);
    }
    Console.WriteLine(n.name);
    if (n.hasRightChild)
    {
      Inorder(n.rightChild);
    }
  }
  
  public static void Postorder(Node n)
  {
    if (n.hasLeftChild)
    {
      Postorder(n.leftChild);
    }
    if (n.hasRightChild)
    {
      Postorder(n.rightChild);
    }
    Console.WriteLine(n.name);
  }
  
  public static bool CheckFull()
  {
    bool isFull = false;

    for (int i = 0; i < nodes.Count; i++)
    {
      if (nodes[i].depth != currentTreeHeight)
      {
        if (nodes[i].hasRightChild && nodes[i].hasLeftChild)
        {
          isFull = true;
        }
        else
        {
          isFull = false;
        }
      }
    }
    return isFull;
  }
  
  public static bool CheckComplete(int index)
  {
    if (root == null)
    {
      return true;
    }
    
    if (index >= numNodes)
    {
      return false;
    }
    
    return (CheckComplete(2 * index + 1) && CheckComplete(2 * index + 2));
  }
}
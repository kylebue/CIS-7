using System;
using System.Collections;
using System.Collections.Generic;

public class Node
{
  public string name = "";
  public bool hasLeftChild = false;
  public bool hasRightChild = false;
  public int depth = 0;
  public Node leftChild {get; set;}
  public Node rightChild {get; set;}
}
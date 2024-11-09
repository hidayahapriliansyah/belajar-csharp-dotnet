using System;

class WhileLoopExample
{
  public static void WhileLoop()
  {
    int i = 0;
    while(i < 5)
    {
      Console.WriteLine(i);
      i++;
    }
  }

  public static void DoWhile()
  {
    int i = 0;
    do
    {
      Console.WriteLine(i);
      i++;
    }
    while(i < 5);
  }
}
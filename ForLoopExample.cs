using System;

class ForLoopExample
{
  public static void For()
  {
    for(int i = 0; i < 5; i++)
    {
      Console.WriteLine(i);
    }
  }

  public static void ForEach()
  {
    string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
    foreach (string car in cars)
    {
      Console.WriteLine($"{car}({car.Length})");
    }
  }
}
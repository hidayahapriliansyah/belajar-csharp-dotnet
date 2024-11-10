using System;

class MethodExample
{
  public static void Greeting(string name, string? addition = "")
  {
    // call private method. Di c# kalau access modifier nya gak diubah itu artinya pakai private
    // MethodExample example = new MethodExample();
    // string greeting = example.CreateGreeting(name, addition);
    // Console.WriteLine(greeting);

    string greeting = CreateGreeting(name: name, addition: addition);
    Console.WriteLine($"Greeting => {greeting}");
  }

  public static string CreateGreeting(string name, string? addition = "")
  {
    return $"Hello {name}. {addition}".Trim();
  }

  public static void MethodOverloading()
  {

  }

  public static int PlusMethod(int x, int y)
  {
    return x + y;
  }

  public static double PlusMethod(double x, double y)
  {
    return x + y;
  }
}
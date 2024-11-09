using System;

class IfElseExample
{
  public static void TheIfStatement()
  {
    Console.Write("Masukkan umur Anda: ");
    int age = Convert.ToInt32(Console.ReadLine());
    if (age >= 18)
    {
      Console.WriteLine("You are kolot bang. Sadar.");
    }
    else
    {
      Console.WriteLine("You are masih muda. Harus sadar juga sih.");
    }
  }

  public static void TheElseIfStatement()
  {
    Console.Write("Masukkan waktu nya kakak: ");
    int time = Convert.ToInt32(Console.ReadLine());
    string greeting;
    if (time <= 10 && time <= 12)
    {
      greeting = "Good morning.";
    }
    else if (time <= 13 && time <= 18)
    {
      greeting = "Good afternoon.";
    }
    else
    {
      greeting = "Good apa ya.";
    }
    Console.WriteLine(greeting);
  }

  public static void Ternary()
  {
    int time = 10;
    string result = (time < 7) ? "On time" : "Late";
    Console.WriteLine(result);
  }
}
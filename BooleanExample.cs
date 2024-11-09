using System;

class BooleanExample
{
  public static void ReaLifeCase()
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
}
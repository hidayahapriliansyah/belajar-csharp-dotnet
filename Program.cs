using System;

class Program
{
  static void Main()
  {
    Motobike motobike1 = new Motobike();
    motobike1.Honk();
    Console.WriteLine(motobike1.brand);
    Console.WriteLine(motobike1.modelName);
  }
}
using System;

class Program
{
  static void Main()
  {
    Person person1 = new Person();
    Console.WriteLine($"person1: {person1}");
    Console.WriteLine($"person1.Name: {person1.Name}");

    person1.Name = "Adi";
    Console.WriteLine($"person1: {person1}");
    Console.WriteLine($"person1.Name: {person1.Name}");
  }
}
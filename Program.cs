using System;

class Program
{
  static void Main()
  {
    Car car1 = new Car(name: "Tesla", model: "X", maxSpeed: 470);

    Console.WriteLine(car1.name);
    Console.WriteLine(car1.model);
    Console.WriteLine(car1.maxSpeed);
  }
}
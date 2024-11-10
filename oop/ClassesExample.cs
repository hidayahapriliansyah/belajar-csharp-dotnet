using System;

class Car
{
  public string model; // variable itu disebut field kalau di c#
  public string name;
  public int maxSpeed;

  public Car(string model, string name, int maxSpeed)
  {
    this.model = model;
    this.name = name;
    this.maxSpeed = maxSpeed;
  }

  // function itu di sebut method
  public void fullThrottle()
  {
    Console.WriteLine("This car is so f***ing fast");
  }

  // Pada materi multiple class eta mah anu sok dilakukeun. di class manggil class lain lalu dibikin instance nya
}
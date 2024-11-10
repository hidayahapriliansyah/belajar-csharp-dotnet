using System;

interface IAnimal 
{
  void AnimalSound();
}

interface IRobot
{
  void Move();
}

class AyamFromInterface : IAnimal, IRobot
{
  public void AnimalSound()
  {
    Console.WriteLine("Kukuruyukkkk ...");
  }

  public void Move()
  {
    Console.WriteLine("Zzzt .. Zzzt");
  }
}
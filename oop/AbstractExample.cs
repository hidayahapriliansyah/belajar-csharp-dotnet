using System;

abstract class AnimalAbstract
{
  public abstract void AnimalSound();

  public void Sleep()
  {
    Console.WriteLine("Zzzz");
  }
}

class AyamDariAbstract : AnimalAbstract
{
  public override void AnimalSound()
  {
    Console.WriteLine("Kukuruyuk ...");
  }
}
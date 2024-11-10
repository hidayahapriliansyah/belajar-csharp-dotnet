using System;

class Program
{
  static void Main()
  {
    AnimalAbstract ayam = new AyamDariAbstract();
    ayam.AnimalSound();
    ayam.Sleep();
  }
}
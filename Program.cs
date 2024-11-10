using System;

class Program
{
  static void Main()
  {
    Animal animal = new Animal();
    Animal ayam = new Ayam();
    Animal cat = new Cat();
    animal.AnimalSound();
    ayam.AnimalSound();
    cat.AnimalSound();
  }
}
using System;

class Animal
{
  // jika tidak menggunakan virtual maka class turunan tidak bisa melakukan overriding
  public virtual void AnimalSound()
  {
    Console.WriteLine(Sound);
  }

  public virtual string Sound { get; set; }
}

class Cat : Animal
{
  public override void AnimalSound()
  {
    Console.WriteLine(Sound);
  }

  public override string Sound { get; set; } = "Meong meong.";
}

class Ayam : Animal
{
  public override void AnimalSound()
  {
    Console.WriteLine(Sound);
  }

  public override string Sound { get; set; } = "Kukuruyuk .... annnnjay";
}
using System;

// sealed class Vehicle . sealed berfungsi agar tidak ada class lain yang tidak mewarisi kelas ini
class Vehicle
{
  public string brand = "Honda";
  public void Honk()
  {
    Console.WriteLine("Ngenggggggg ....");
  }
}

class Motobike : Vehicle
{
  public string modelName = "Vario";
}
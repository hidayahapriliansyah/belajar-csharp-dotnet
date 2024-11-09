using System;

class SwitchExample
{
  public static void Example()
  {
    Console.WriteLine("Masukkan bilangan hari: ");
    int day = Convert.ToInt32(Console.ReadLine());
    switch (day)
    {
      case 1:
        Console.WriteLine("Ahad");
        break;
      case 2:
        Console.WriteLine("Senin");
        break;
      case 3:
        Console.WriteLine("Selasa");
        break;
      case 4:
        Console.WriteLine("Rabu");
        break;
      case 5:
        Console.WriteLine("Kamis");
        break;
      case 6:
        Console.WriteLine("Jumat");
        break;
      case 7:
        Console.WriteLine("Sabtu");
        break;
      default:
        Console.WriteLine("Invalid day number.");
        break;
    }
  }
}
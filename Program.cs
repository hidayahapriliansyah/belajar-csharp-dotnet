using System;

class Program
{
  static void Main()
  {
    AyamFromInterface ayam = new AyamFromInterface();
    // kalau untu polimorfism bisa pakai type variable class induknya
    // kalau untuk object dari interface langsung type dai class implementasinya aja karena implementasi class bisa lebih dari 1 interface
    ayam.AnimalSound();
    ayam.Move();
  }
}
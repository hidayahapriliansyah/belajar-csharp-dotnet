using System;

class OperatorExample
{
  public static void Arithmetic()
  {
    int x = 10;
    int y = 20;

    Console.WriteLine($"Addition x + y: {x + y}");
    Console.WriteLine($"Substraction x - y: {x - y}");
    Console.WriteLine($"Multiplication x * y: {x * y}");
    Console.WriteLine($"Division x / y: {x / y}");
    Console.WriteLine($"Modulus x % y: {x % y}");
    Console.WriteLine($"Increment x++: {x++}");
    Console.WriteLine($"Decrement x--: {x--}");

    double xDouble = 10.0;
    Console.WriteLine($"int + double: {x + xDouble}");
    Console.WriteLine($"int + double: {(x + xDouble).GetType()}");
  }

  public static void Assignment()
  {
    // int sepuluh = 10;

    // int plusSamadengan = sepuluh += 5;
    // Console.WriteLine($"plusSamadengan : {plusSamadengan}");

    // int minSamadengan = sepuluh -= 5;
    // Console.WriteLine($"minSamadengan : {minSamadengan}");

    // int bintangSamadengan = sepuluh *= 5;
    // Console.WriteLine($"bintangSamadengan : {bintangSamadengan}");

    int coba1 = 10;
    // int coba2 = coba1 &= 2;
    // Console.WriteLine(coba2);

    // int coba3 = coba1 %= 3;
    // Console.WriteLine(coba3);

    // int coba4 = coba1 |= 3;
    // Console.WriteLine(coba4);

    // int coba5 = coba1 ^= 3;
    // Console.WriteLine(coba5);

    // int coba6 = coba1 >>= 3;
    // Console.WriteLine(coba6);

    // int coba7 = coba1 <<= 3;
    // Console.WriteLine(coba7);
  }

  public static void Comparison()
  {
    Console.WriteLine($"5 == 5 {5 == 5}");
    Console.WriteLine($"5 != 5 {5 != 5}");
    Console.WriteLine($"5.0 == 5 {5.0 == 5}");
    Console.WriteLine($"5.0 > 5 {5.0 > 5}");
    Console.WriteLine($"5.1 > 5 {5.1 > 5}");
    Console.WriteLine($"1 < 5 {1 < 5}");
    Console.WriteLine($"5 >= 5 {5 >= 5}");
    Console.WriteLine($"6 >= 5 {6 >= 5}");
    Console.WriteLine($"5 <= 6 {5 <= 6}");
  }

  public static void Logical()
  {
    const bool myBool = false && false;
    Console.WriteLine($"myBool == false {myBool == false}");

    // Console.WriteLine($"true && true: {true && true}");
    // Console.WriteLine($"true || false: {true || false}");
    // Console.WriteLine($"!true: {!true}");
  }
}
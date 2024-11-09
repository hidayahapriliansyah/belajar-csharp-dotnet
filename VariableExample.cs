using System;

class VariableExample
{
  public static void SimpleVariable()
  {
    int satu = 1;
    Console.WriteLine(satu);

    string firstName = "Adi";
    string lastName = "Firmansyah";
    string fullName = firstName + " " + lastName;
    Console.WriteLine("Name : " + fullName);
    
    int myNumber;
    myNumber = 10;
    Console.WriteLine(myNumber);

    double decimalNumber = 1.2;
    Console.WriteLine(decimalNumber);

    char myLetter = 'A';
    Console.WriteLine(myLetter);

    bool bureanTrue = true;
    bool bureanFalse = false;
    Console.WriteLine(bureanTrue);
    Console.WriteLine(bureanFalse);
  }

  public static void Constants() {
    const int myNum = 15;
    // myNum = 10; it will cause an error
    Console.WriteLine(myNum);
  }

  public static void Display()
  {
    string name = "Abangbang";
    Console.WriteLine("Hello " + name);

    int x = 5;
    int y = 6;
    Console.WriteLine(y + x);
    Console.WriteLine(y + name);
  }

  public static void DeclareMany()
  {
    int x = 1,
      y = 2,
      z = 3;
    Console.WriteLine(x);
    Console.WriteLine(y);
    Console.WriteLine(z);

    int a, b, c;
    a = b = c = 20;
    Console.WriteLine(a + b + c);
  }
}
using System;

class TypeCastingExample
{
  /*
    Implicit Casting (automatically) - converting a smaller type to a larger type size
    char -> int -> long -> float -> double

    Explicit Casting (manually) - converting a larger type to a smaller size type
    double -> float -> long -> int -> char
  */

  public static void Implicit()
  {
    int myInt = 9;
    Console.WriteLine(myInt);
    Console.WriteLine("Type of myInt: " + myInt.GetType());

    double myDouble = myInt;
    Console.WriteLine(myDouble);
    Console.WriteLine("Type of myDouble: " + myDouble.GetType());
  }

  public static void Explicit()
  {
    double myDouble = 9.2;
    Console.WriteLine($"Type of myDouble: {myDouble.GetType()}");

    int myInt = (int) myDouble;
    Console.WriteLine($"Type of myInt: {myInt.GetType()}");
  }

  public static void TypeConversion()
  {
    int myInt = 10;
    double myDouble = 1.2;
    bool myBool = true;

    string myStrFromInt = Convert.ToString(myInt);
    Console.WriteLine($"myStrFromInt: {myStrFromInt}\nType of myStrFromInt {myStrFromInt.GetType()}");

    string myStrFromBool = Convert.ToString(myBool);
    Console.WriteLine($"myStrFromBool: {myStrFromBool}\nType of myStrFromBool {myStrFromBool.GetType()}");

    double myDoubleFromInt = Convert.ToDouble(myInt);
    Console.WriteLine($"myDoubleFromInt: {myDoubleFromInt}\nType of myDoubleFromInt {myDoubleFromInt.GetType()}");

    double myDoubleFromBool = Convert.ToDouble(myBool);
    Console.WriteLine($"myDoubleFromBool: {myDoubleFromBool}\nType of myDoubleFromBool {myDoubleFromBool.GetType()}");

    bool myBoolFromDouble = Convert.ToBoolean(myDouble);
    Console.WriteLine($"myBoolFromDouble: {myBoolFromDouble}\nType of myBoolFromDouble {myBoolFromDouble.GetType()}");

    bool myBoolFromDouble2 = Convert.ToBoolean(0.0);
    Console.WriteLine($"myBoolFromDouble2: {myBoolFromDouble2}");

    // bool myBoolFromString = Convert.ToBoolean("True"); ini akan berhasil
    // bool myBoolFromString = Convert.ToBoolean("False"); ini akan berhasil
    // bool myBoolFromString = Convert.ToBoolean("true"); ini akan berhasil
    // bool myBoolFromString = Convert.ToBoolean("false"); ini akan berhasil
    // bool myBoolFromString = Convert.ToBoolean(" "); ini akan error
    // Console.WriteLine($"myBoolFromString: {myBoolFromString}");
  }
}
using System;

class UserInputExample
{
  public static void GetUserInput()
  {
    Console.WriteLine("Enter username: ");

    string username = Console.ReadLine();

    Console.WriteLine($"Username is {username}");
  }

  public static void UserInputAndNumbers()
  {
    Console.Write("Enter your age: ");
    int age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Your age: {age}");
  }
}
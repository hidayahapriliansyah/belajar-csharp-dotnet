using System;

class BreakContinueExample
{
  public static void Break()
  {
    for (int i = 0; i < 10; i++) 
    {
      if (i == 4) 
      {
        break;
      }
      Console.WriteLine(i);
    }

    int j = 0;
    while (j < 10)
    {
      if (j == 4) 
      {
        break;
      }
      Console.WriteLine(j);
      j++;
    }
  }

  public static void Continue()
  {
    for (int i = 0; i < 10; i++) 
    {
      if (i == 4) 
      {
        continue;
      }
      Console.WriteLine(i);
    }

    int j = 0;
    while (j < 10)
    {
      if (j == 4) 
      {
        j++;
        continue;
      }
      Console.WriteLine(j);
      j++;
    }
  }
}
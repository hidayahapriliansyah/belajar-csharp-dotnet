using System;
using System.Collections.Generic;

class OutParameter
{
  public static void Example()
  {
    List<string> shoppingList = new List<string>
    {
      "Kopi", "Susu"
    };

    FindInList("Kpi", shoppingList, out int anjay);
    Console.WriteLine(anjay);
    // Console.WriteLine(shoppingList);
  }

  static bool FindInList(string text, List<string> list, out int index)
  {
    index = -1;

    for (int i = 0; i < list.Count; i++)
    {
      if (list[i].ToLower().Equals(text.ToLower()))
      {
        index = i;
      }
    }

    return index > -1;
  }
}
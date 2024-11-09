using System;
using System.Linq;

class ArrayExample
{
  public static void Arrays()
  {
    // string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
    // int[] myNums = {1, 2, 3};

    // Console.WriteLine(myNums);
    // Console.WriteLine(myNums.Length);

    // chanage array element
    // cars[0] = "Avanza";
    // Console.WriteLine(cars[0]);
    // Console.WriteLine(string.Join(", ", cars));

    // other ways to create array

    // string[] gadgets = {"Samsung", "Apple", "Nokia"};

    // string[] gadgets;
    // gadgets =  new string[] {"Samsung", "Apple", "Nokia"};
    // Console.WriteLine(string.Join(", ", gadgets));

    // string[] gadgets;
    // gadgets = {"Samsung", "Apple", "Nokia"};
    // Console.WriteLine(string.Join(", ", gadgets));
    //  hal di atas akan gagal karena assignment nilai tidak diawali new string[]

    // string[] gadgets;
    // gadgets = new string[3] {"Samsung", "Apple", "Nokia"};
    // Console.WriteLine(string.Join(", ", gadgets));

    // string[] gadgets = new string[3] {"Samsung", "Apple", "Nokia"};
    // Console.WriteLine(string.Join(", ", gadgets));

    // string[] gadgets = new string[10];
    // gadgets = new string[4] {"Samsung", "Apple", "Nokia", ""};
    // Console.WriteLine(string.Join(", ", gadgets));
    // hal di atas tetap berjalan dengan baik karena alokasi memory yang dipakai adalah yang terakhir saat assigne nilai new string[4] 

    string[] gadgets = new string[1];
    Console.WriteLine($"gadgets[0] == null: {gadgets[0] == null}");
    Console.WriteLine(string.Join(", ", gadgets));
  }

  public static void LoopArray()
  {
    string[] gadgets = {"Samsung", "Apple", "Nokia"};
    foreach (string gadget in gadgets)
    {
      Console.WriteLine(gadget);
    }

    for(int i = 0; i < gadgets.Length; i++)
    {
      Console.WriteLine(gadgets[i]);
    }
  }

  public static void SortArray()
  {
    string[] gadgets = {"Samsung", "Apple", "Nokia"};
    Array.Sort(gadgets);
    foreach (string gadget in gadgets)
    {
      Console.WriteLine(gadget);
    }

    int[] numbers = { 2134, 23423, 4234, 3245, 24323, 4 };
    Array.Sort(numbers);
    Array.Reverse(numbers);
    foreach (int number in numbers)
    {
      Console.WriteLine(number);
    }
  }

  public static void SystemLinq()
  {
    // int[] numbers = { 2134, 23423, 4234, 3245, 24323, 4 };
    // Console.WriteLine(numbers.Min());
    // Console.WriteLine(numbers.Max());
    // Console.WriteLine(numbers.Sum());

    //  yang di bawah hasil ngulik dari chat gpt
    int[] numbers = { 2, 1, 4, 5, 6, 7, 8, 9, 3 };
    // var sortedAsc = numbers.OrderBy(n => n);
    // Console.WriteLine(string.Join(", ", sortedAsc));

    // var sortedDesc = numbers.OrderByDescending(n => n);
    // Console.WriteLine(string.Join(", ", sortedDesc));

    // Console.WriteLine(string.Join(", ", numbers));

    // var greaterThanFive = numbers.Where(n => n > 5);
    //  mirip filter di js
    // Console.WriteLine(string.Join(", ", greaterThanFive));

    // var multipledBy10 = numbers
    //   .OrderBy(n => n)
    //   .Select(n => n * 10);
    // Console.WriteLine(string.Join(", ", multipledBy10));
    // mirip map

    // var firstGreaterThan7 = numbers.First(n => n > 7);
    // Console.WriteLine(firstGreaterThan7.GetType() == typeof(int));

    // var firstGreaterThan9OrDefault = numbers.FirstOrDefault(n => n > 9);
    // Console.WriteLine(firstGreaterThan9OrDefault);

    // var lastGreaterThan7 = numbers.Last(n => n > 7);
    // Console.WriteLine(lastGreaterThan7);

    // var lastGreaterThan7Default = numbers.LastOrDefault(n => n > 9);
    // Console.WriteLine(lastGreaterThan7Default);

    // bool hasGreaterThan9 = numbers.Any(n => n > 9);
    // Console.WriteLine(hasGreaterThan9);
    // return boolean

    // bool allLessThan9 = numbers.All(n => n <= 9);
    // Console.WriteLine(allLessThan9);

    // var average = numbers.Average();
    // Console.WriteLine(average);

    // int[] listNumber = { 1, 1, 1, 2 };
    // var distinctListNumber = listNumber.Distinct();
    // Console.WriteLine(string.Join(", ", distinctListNumber));
    // mengembalikan  nilai unique yaitu 1, 2

    // var listNumber = numbers.ToList();
    // Console.WriteLine(listNumber.GetType());
    // Console.WriteLine(string.Join(", ", listNumber));

    // var dictionaryNumber = numbers.ToDictionary(n => n, n => n * 2);
    // Console.WriteLine(dictionaryNumber.GetType());
    // Console.WriteLine(string.Join(", ", dictionaryNumber));

    // var total = numbers.Aggregate((a, b) => a + b);
    // Console.WriteLine(total);

    // int[] otherNumbers = { 1, 2, 1, 1, 3, 3 };
    // var groupedNumbers = otherNumbers.GroupBy(n => n);
    // Console.WriteLine(groupedNumbers.GetType());
    // foreach (var group in groupedNumbers)
    // {
    //     Console.WriteLine($"Number: {group.Key}, Count: {group.Count()}");
    // }

    // int[] numbers1 = {1, 2, 3};
    // int[] numbers2 = {4, 5, 6};
    // int[] numbers3 = {7, 8, 9};

    // var concatResult = numbers1.Concat(numbers2, numbers3);
    // Console.WriteLine(string.Join(", ", concatResult));

    int[] myNums1 = { 1, 2, 3 };
    int[] myNums2 = { 3, 4, 5 };
    // var intersectNums = myNums1.Intersect(myNums2);
    // Console.WriteLine(intersectNums.GetType());
    // Console.WriteLine(string.Join(", ", intersectNums));
    // var exectNums = myNums1.Except(myNums2);
    // Console.WriteLine(string.Join(", ", exectNums));
    // excpet akan mengembalikan array dengan item yang ada di arr pertama tapi tidak di array kedua

    // zip
  }

  public static void ZipExample()
  {
    int[] numbers = { 1, 2, 3 };
    string[] words = { "Satu", "Dua", "Tiga" };

    var zippedNumbers = numbers.Zip(words, (n, w) => new { Number = n, Word = n });
    foreach (var item in zippedNumbers)
    {
      Console.WriteLine($"Number: {item.Number}, Word: {item.Word}");
    }
  }

  public static void ToLookUpExample()
  {
    var people = new[]
    {
      new { Name = "John", Age = 25 },
      new { Name = "Jane", Age = 25 },
      new { Name = "Bill", Age = 30 },
      new { Name = "Anna", Age = 30 },
    };

    var lookupResult = people.ToLookup(p => p.Age);
    foreach (var ageGroup in lookupResult)
    {
      Console.WriteLine(ageGroup.Key);
      foreach (var person in ageGroup)
      {
        Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
      }
    }
  }

  public static void TakeExample()
  {
    int[] numbers = { 1, 2, 3, 4, 5, 6 };

    var takeFirst2 = numbers.Take(2);
    Console.WriteLine(string.Join(", ", takeFirst2).Trim());

    var takeLessThanEqual4 = numbers.TakeWhile(n => n <= 4);
    Console.WriteLine(string.Join(", ", takeLessThanEqual4).Trim());
    // Console.WriteLine(takeLessThanEqual4 == new int[] { 1, 2, 3, 4 });
    // yang atas nilainya False karena ternyata yang dibandingkan termasuk object referensi dan letak memory variable
    // Console.WriteLine(takeLessThanEqual4.ToArray() == new int[] { 1, 2, 3, 4 });
    // yang atas lagi juga false

    // Console.WriteLine(takeLessThanEqual4.SequenceEqual(new int[] { 1, 2, 3, 4 }));
    // yang ini nilainya true. SequenceEqual merupakan bagian dari Linq
  }

  public static void SkipExample()
  {
    int[] numbers = { 1, 2, 3, 4, 5, 6 };

    var skipFirst5 = numbers.Skip(5);
    Console.WriteLine(string.Join(", ", skipFirst5).Trim());
    Console.WriteLine(skipFirst5.SequenceEqual(new int[] { 6 }));

    var skipLessThanEqual4 = numbers.SkipWhile(n => n <= 4);
    Console.WriteLine(string.Join(", ", skipLessThanEqual4));
    Console.WriteLine(skipLessThanEqual4.SequenceEqual(new int[] { 5, 6 }));
  }

  public static void DefaultIfEmptyExample()
  {
    int[] numbers = { };
    var result = numbers.DefaultIfEmpty(0);
    Console.WriteLine(string.Join(", ", result));
  }

  public static void ToListExample()
  {
    int[] numbers = { 1, 2, 2, 3 };
    var result = numbers.ToList();
    Console.WriteLine(string.Join(", ", result));
  }

  public static void MultiDimensionalArray()
  {
    int[,] arr = { { 1, 3, 5 }, { 2, 4, 6 } };
    int targetItem = arr[1, 0];
    Console.WriteLine(targetItem == 2);

    //  change value
    arr[1, 0] = 0;
    int targetItemAfterChange = arr[1, 0];
    Console.WriteLine(targetItem == 2);
    Console.WriteLine(targetItemAfterChange == 0);

    foreach (int item in arr)
    {
      Console.WriteLine(item);
    }

    for (int i = 0; i < arr.GetLength(0); i++)
    {
      for (int j = 0; j < arr.GetLength(1); j++)
      {
        Console.WriteLine($"Pakai For biasa {arr[i, j]}");
      }
    }

    // coba bisa bikin 3 gak
    int[,,] arr3d = {
      { {1, 2}, {3, 4} },
      { {5, 6}, {7, 8} },
    };

    foreach (var i in arr3d)
    {
      Console.WriteLine($"arr3d: {i}");
    }
  }
}
using System;

class StringsExample
{ 
  public static void Length()
  {
    string text = "Hello";
    Console.WriteLine(text.Length);
  }

  public static void Methods()
  {
    string text = "Adi Muhamad Firmansyah";
    // Console.WriteLine(text.ToUpper());
    // Console.WriteLine(text.ToLower());

    // Console.WriteLine(text.Substring(12, 10));
    // it will return Firmansyah

    // Console.WriteLine(text.IndexOf('a'));
    // Console.WriteLine(text.Contains("Firmansyah"));

    // Console.WriteLine(text.Replace("Muhamad Firmansyah", "Hidayah Apriliansyah"));
    // it will return Adi Hidayah Apriliansyah

    // string text2 = "           Wuzz          ";
    // Console.WriteLine(text2.Trim());
    // Console.WriteLine(text2);
    // it will return Wuzz
    // tidak mengubah variable asli

    // Console.WriteLine(text.Split(" "));
    // menghasilakan System.String[]

    // System.String[] textString = text.Split(" ");
    // Console.WriteLine(System.String.Join(", ", textString));
    // string[] textString = text.Split(" ");
    // Console.WriteLine(string.Join(", ", textString));

    // const System.Int32 myNumber = 10;
    // Console.WriteLine(myNumber);
    // ternyata string itu alias untuk System.String begitu pun untuk type yang lain

    // Console.WriteLine(text.StartsWith("Adi")); return boolean
    // Console.WriteLine(text.EndsWith("Firmansyah"));

    // char[] charArray = text.ToCharArray();
    // Console.WriteLine(string.Join(", ", charArray));

    // Console.WriteLine(text.Length);
    // Console.WriteLine(text.PadLeft(5).Length);
    // Console.WriteLine(text.PadRight(5).Length);

    // Console.WriteLine(text.Insert(4, "Ganteng "));

    // Console.WriteLine(text.Remove(10, 2));

    // string text2 = "Hello";
    // string text3 = "hello";
    // Console.WriteLine(text2.Equals(text3));

    // Console.WriteLine(text2.CompareTo(text3));

    // Console.WriteLine(string.IsNullOrEmpty(text));

    const string whiteSpace = "            ";
    Console.WriteLine(string.IsNullOrWhiteSpace(whiteSpace));
  }

  public static void Concatenation()
  {
    string firstName = "Adi ";
    string lastName = "Firmansyah";
    // Console.WriteLine(firstName + lastName);
    Console.WriteLine(string.Concat(firstName, lastName));
    string fullName = firstName + lastName;
    Console.WriteLine(fullName + 25);
  }

  public static void Interpolation()
  {
    string name = "Adi Muhamad Firmansyah";
    Console.WriteLine($"Hello nama saya {name}");
  }

  public static void AccessString()
  {
    string name = "Adi Muhamad Firmansyah";
    int charPosF = name.IndexOf("F");
    Console.WriteLine(name.Substring(charPosF));
  }

  public static void SpecialCharacters()
  {
    string text = "Nama Hokage ke-4 di serial Naruto adalah Minato Namikaze yang memiliki julukan \"Si Kilat Kuning dari Konoha\"";
    Console.WriteLine(text);
    // Console.WriteLine("\n");
    // Console.WriteLine("\t");
    Console.WriteLine("\b");
  }
}
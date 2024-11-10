enum EMonth
{
  January,
  February
}

class Month
{
  // enum bisa disimpan di dalam class
  // public enum EMonth
  // {
  //   January,
  //   February
  // }

  public static EMonth getMonth()
  {
    return EMonth.January;
  }
}
using System;
using System.Collections.Generic;

class MainClass {
  static void Main(string[] args)
  {
    List<int> nums = new List<int>(new int[]{1, 2, 3, 5, 10, 20});

    Console.WriteLine(notContains(nums));
  }

  public static int notContains(List<int> array) {
    int minimal = 1;
    while (array.Contains(minimal)) {
      minimal +=1;
    }
    return minimal;
  }
}
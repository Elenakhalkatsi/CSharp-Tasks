using System;
using System.Collections.Generic;

class MainClass {
  static void Main(string[] args)
  {
    List<int> coins = new List<int>(new int[]{1, 5, 10, 20, 50});
    coins.Sort();
    coins.Reverse(); 

    Console.Write("Fill in your money: ");
    int amount = Convert.ToInt16(Console.ReadLine());

    Console.WriteLine(minSplit(amount, coins));
  }
  
  public static int minSplit(int amount, List<int> list) {
    int minimal = 0;
    for (int i = 0; i < list.Count; i++) {
      minimal += amount / list[i];
      amount = amount % list[i];
    }
    return minimal;
  }
}
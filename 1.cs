using System;
using System.Collections.Generic;

class MainClass {
  static void Main(string[] args)
  {
    Console.Write("Input string: ");
    string inputString = Console.ReadLine();

    bool isPalindromeOrNot = isPalindrome(inputString); 
    Console.WriteLine(isPalindromeOrNot);
  }

  public static bool isPalindrome(string text){
    int len = text.Length;
    int lenForIndex = len - 1;
    for (int i = 0; i < len/2; i++)
    {
      if (text[i] != text[lenForIndex - i]) {
        return false;
      }
    }
    return true;
  }
}

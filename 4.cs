using System;
using System.Collections.Generic;

class MainClass
{
    static void Main(string[] args) {
        Console.Write("Fill in your string: ");
        string myString = Console.ReadLine();

        Console.WriteLine(isProperly(myString));
    }
    public static bool isProperly(string sequence) {
        int brackets = 0;
        for (int i = 0; i < sequence.Length; i++) {
            if (brackets < 0) {
                return false;
            } else if ((sequence[i]).ToString() == ")") {
                brackets = brackets - 1;
            } else if ((sequence[i]).ToString() == "(") {
                brackets++;
            }
        }
        if (brackets == 0) {
            return true;
        }
        return false;
    }
}

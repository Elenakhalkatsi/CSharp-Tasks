using System;
using System.Collections.Generic;

class MainClass
{
    static void Main(string[] args)
    {
        int index;
        List<int> list = new List<int>(new int[] { 1, 2, 3, 5, 10, 20 });

        list[index] = list[list.Count - 1];
        list.RemoveAt(list.Count - 1);
    }
}
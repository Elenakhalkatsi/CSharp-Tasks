using System;
using System.Collections.Generic;

class MainClass
{
    static void Main(string[] args)
    {
        Console.Write("Stears: ");
        int stears = Int16.Parse(Console.ReadLine()); 

        Console.WriteLine(countVariants(stears));
    }
    public static int countVariants(int stearsCount)
    {
        int variants = 0;
        int m, n;
        for (int i = 0; i <= stearsCount/2; i++)
        {
            m = i;
            n = i + (stearsCount - i * 2);
            int variant = factorial(n) / (factorial(m) * factorial(n - m));
            variants = variants + variant;
        }
        return variants;

    }
    public static int factorial(int num)
    {
        int i, fact = 1;
        for (i = 1; i <= num; i++)
        {
            fact = fact * i;
        }
        return fact;
    }
}

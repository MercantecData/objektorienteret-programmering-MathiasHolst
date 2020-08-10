using System;
using System.Collections.Concurrent;

namespace OverloadingMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Math matFunktioner = new Math();
            Console.WriteLine($"{matFunktioner.plus(5f, 5f)}");
            Console.WriteLine($"{matFunktioner.minus(5f, 5f)}");
            Console.WriteLine($"{matFunktioner.gange(5f, 5f)}");
            Console.WriteLine($"{matFunktioner.divider(5f, 5f)}");
            Console.WriteLine($"{matFunktioner.potens(5f, 5f)}");
            Console.WriteLine($"{matFunktioner.kvadratrod(5f)}");

            Math.plusFloatDel plusDel = matFunktioner.plus;
            Console.WriteLine(plusDel(1, 3));
            Math.plusIntExp plusExp = (int a, int b) => a + b;
            Console.WriteLine(plusExp(2, 3));
        }
    }
}

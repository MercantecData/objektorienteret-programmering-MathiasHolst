using System;

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
        }
    }
}

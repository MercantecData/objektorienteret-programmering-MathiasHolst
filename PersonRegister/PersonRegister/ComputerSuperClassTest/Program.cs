using System;
using ComputerSuperClass;

namespace ComputerSuperClassTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer macbook = new Bærbar("macbook", 9000, "1234");
            Console.WriteLine($"{macbook.name} is turned on: {macbook.powerOn()}");
            Console.WriteLine($"{macbook.name} is turned on: {macbook.powerOff()}");
        }
    }
}

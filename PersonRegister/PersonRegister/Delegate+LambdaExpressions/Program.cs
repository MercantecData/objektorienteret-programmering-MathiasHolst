using System;
using System.Reflection.Metadata.Ecma335;

namespace Delegate_LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Delegates.firstDel del1 = Delegates.target;
            del1();

            Delegates.floatDel del2 = Delegates.targetFloat;
            del2();

            Delegates.treParametre del3 = Delegates.targetVoidMedParametre;
            del3(3, 4, 8);

            Delegates.firstLambdaExp exp1 = (int a) => a*2;
            Console.WriteLine(exp1(4));

            Delegates.lambdaExpTreParametre exp2 = (float a, float b, float c) => a + b + c;
            Console.WriteLine(exp2(3, 5, 6));

            Delegates.helloWorldExp exp3 = () => Console.WriteLine("Hello World");
            exp3();
        }
    }
}

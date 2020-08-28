using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate_LambdaExpressions
{
    public class Delegates
    {
       public delegate void firstDel();
       public delegate float floatDel();
       public delegate void treParametre(int a, int b, int c);
       public delegate int firstLambdaExp(int a);
       public delegate float lambdaExpTreParametre(float a, float b, float c);
       public delegate void helloWorldExp();

       public static void target()
       {
            Console.WriteLine("void works!");
       }

       public static float targetFloat()
       {
            Console.WriteLine("float works!");
            return 1 + 1;
       }

       public static void targetVoidMedParametre(int a, int b, int c)
        {
            Console.WriteLine($"void with 3 parametres works! result: {a + b + c}");
        } 
    }

}

using System;
using System.Collections.Generic;

namespace DictionariesMedTalOgBools
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> numbersList = new Dictionary<string, int>();

            numbersList.Add("uno", 1);
            numbersList.Add("two", 2);
            numbersList.Add("trois", 3);
            numbersList.Add("vier", 4);
            numbersList.Add("fünf", 5);
            numbersList.Add("seks", 6);
            numbersList.Add("sieben", 7);
            numbersList.Add("acht", 8);
            numbersList.Add("neun", 9);
            numbersList.Add("zehn", 10);

            Console.WriteLine(numbersList["trois"]);

            /////////////////////////////////////////////////////////////////////////////

            Dictionary<float, bool> booleanList = new Dictionary<float, bool>();

            booleanList.Add(1, false);
            booleanList.Add(2, true);
            booleanList.Add(3, false);
            booleanList.Add(4, true);
            booleanList.Add(5, false);
            booleanList.Add(6, true);
            booleanList.Add(7, false);
            booleanList.Add(8, true);
            booleanList.Add(9, false);
            booleanList.Add(10, true);

            Console.WriteLine(booleanList[10]);

        }
    }
}

using System;
using System.Collections.Generic;
using PersonRegister;

namespace PersonRegisterTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Job job1 = new Job("Astronaut", "SpaceX", 100000);
            Person person1 = new Person("Timmy", 33, job1);
            Job job2 = new Job("Hitman", "classified", 0);
            Person person2 = new Person("Solotov", 41, job2);

            var testList = person1.listOfPeople;

            testList.Add(person1);
            testList.Add(person2);

            for(int i = 0; i < testList.Count; i++)
            {
                Console.WriteLine(testList[i].name);
            }
            
            person1.job.salary = 999999;

            var navnOgAlder = new Dictionary<string, int>();

            navnOgAlder["Timmy"] = 33;
            navnOgAlder["Solotov"] = 41;

            Console.WriteLine($"Timmy is {navnOgAlder["Timmy"]} years old.");
            //Timmy's birthday
            navnOgAlder["Timmy"] += 1;
            Console.WriteLine($"It was Timmy's birthday yesterday and he is now {navnOgAlder["Timmy"]}.");
        }
    }
}
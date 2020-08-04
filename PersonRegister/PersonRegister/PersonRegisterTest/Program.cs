using System;
using System.Collections.Generic;
using PersonRegister;

namespace PersonRegisterTest
{
    class Program
    {
        static void Main(string[] args)
        {
            RegisterFunktioner funktioner = new RegisterFunktioner();
            Job job1 = new Job("Astronaut", "SpaceX", 100000);
            Person person1 = new Person("Timmy", 33, job1);
            Job job2 = new Job("Hitman", "classified", 0);
            Person person2 = new Person("Solotov", 41, job2);

            funktioner.AddToList(person1);
            funktioner.AddToList(person2);

            for(int i = 0; i < funktioner.listOfPeople.Count; i++)
            {
                Console.WriteLine(funktioner.listOfPeople[i].name);
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
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
            //funktioner.RemoveFromList(person2);

            for(int i = 0; i < funktioner.listOfPeople.Count; i++)
            {
                Console.WriteLine(funktioner.listOfPeople[i].name);
            }
            
            person1.job.salary = 999999;

            funktioner.navnOgAlder["Timmy"] = 33;
            funktioner.navnOgAlder["Solotov"] = 41;

            string s = Console.ReadLine();

            Console.WriteLine($"{s} is {funktioner.navnOgAlder[s]} years old.");
            //The chosen's birthday
            funktioner.navnOgAlder[s] += 1;
            Console.WriteLine($"It was {s}'s birthday yesterday and he is now {funktioner.navnOgAlder[s]}.");
        }
    }
}
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
            Person person1 = new Person("Timmy", 33, job1, "America");
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

            funktioner.navnOgAlderDic["Timmy"] = 33;
            funktioner.navnOgAlderDic["Peter"] = 41;

            string s = Console.ReadLine();

            Console.WriteLine($"{s} is {funktioner.navnOgAlderDic[s]} years old.");
            //The chosen's birthday
            funktioner.navnOgAlderDic[s] += 1;
            Console.WriteLine($"It is {s}'s birthday today and he is turning {funktioner.navnOgAlderDic[s]}!");
        }
    }
}
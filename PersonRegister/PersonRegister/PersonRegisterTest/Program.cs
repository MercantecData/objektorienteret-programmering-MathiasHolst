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
            person person1 = new person("Timmy", 33, job1);
            Job job2 = new Job("Hitman", "classified", 0);
            person person2 = new person("Solotov", 41, job2);

            List<person> listOfPeople = new List<person>();

            listOfPeople.Add(person1);
            listOfPeople.Add(person2);

            for(int i = 0; i < listOfPeople.Count; i++)
            {
                Console.WriteLine(listOfPeople[i].name);
            }
            

            person1.job.salary = 999999;

            //Console.WriteLine(person1.name);
            //Console.WriteLine(person1.age);
            //Console.WriteLine(person1.job.jobtitle);
            //Console.WriteLine(person1.job.salary);


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
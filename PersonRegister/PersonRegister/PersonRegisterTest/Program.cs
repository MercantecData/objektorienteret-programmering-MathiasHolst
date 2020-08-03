using System;
using PersonRegister;

namespace PersonRegisterTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Job job1 = new Job("Astronaut", "SpaceX", 100000);
            person person1 = new person("Timmy", 33, job1);

            person1.job.salary = 999999;

            Console.WriteLine(person1.name);
            Console.WriteLine(person1.age);
            Console.WriteLine(person1.job.jobtitle);
            Console.WriteLine(person1.job.salary);
        }
    }
}
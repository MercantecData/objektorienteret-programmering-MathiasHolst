using System;
using AbstractClassAndInterfaces;

namespace AbstractClassAndInterfacesTest
{
    class Program
    {
        static void Main(string[] args)
        {
            SupClass2 list = new SupClass2();
            Person person1 = new Person("Søren", 19, Person.Gender.Male);
            Person person2 = new Person("Cecilie", 21, Person.Gender.Female);
            Person person3 = new Person("Maja", 16, Person.Gender.Female);
            Person person4 = new Person("Silas", 7, Person.Gender.Male);
            Person person5 = new Person("Mikkel", 18, Person.Gender.Male);
            Person person6 = new Person("Signe", 23, Person.Gender.Female);
            Person person7 = new Person("Mathias", 17, Person.Gender.Male);
            Person person8 = new Person("Casper", 19, Person.Gender.Male);
            Person person9 = new Person("Josefine", 18, Person.Gender.Female);
            Person person10 = new Person("Jeppe", 20, Person.Gender.Male);

            person1.people.Add(person1);
            person1.people.Add(person2);
            person1.people.Add(person3);
            person1.people.Add(person4);
            person1.people.Add(person5);
            person1.people.Add(person6);
            person1.people.Add(person7);
            person1.people.Add(person8);
            person1.people.Add(person9);
            person1.people.Add(person10);

            person1.CompareTo(person1.people);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(person1.people[i].name, person1.people[i].age);
            }
        }
    }
}

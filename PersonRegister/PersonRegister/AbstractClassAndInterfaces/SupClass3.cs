using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassAndInterfaces
{
    public class Person : AbstractClass
    {
        public string name;
        public int age;
        public Gender gender;

        public List<Person> people = new List<Person>();

        public Person(string name, int age, Gender gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }
        public enum Gender
        {
            Male,
            Female,
            Other,
        }
        public override int AbstractFunc()
        {
            return 3;
        }
    }
}

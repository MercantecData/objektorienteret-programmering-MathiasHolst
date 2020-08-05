using System;
using System.Collections.Generic;
using System.Text;

namespace SkoleSystem
{
    public class Employee
    {
        public string name;
        public int age;
        public bool salaryPayed;
        public Course course;

        public Employee(string name, int age, bool salaryPayed, Course course)
        {
            this.name = name;
            this.age = age;
            this.salaryPayed = salaryPayed;
            this.course = course;
        }
    }
}

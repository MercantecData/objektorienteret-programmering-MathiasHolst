using System;
using System.Collections.Generic;
using System.Text;

namespace SkoleSystem
{
    public class Employee : Person
    {
        public bool salaryPayed;
        
        public Employee(string name, int age, bool salaryPayed, Course course)
        {
            this.name = name;
            this.age = age;
            this.salaryPayed = salaryPayed;
            this.course = course;
        }
    }
}

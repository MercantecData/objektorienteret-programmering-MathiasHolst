using System;
using System.Collections.Generic;
using System.Text;

namespace SkoleSystem
{
    public class Student : Person
    {
        public Employee teacher;
        public Student(string name, int age, Employee teacher, Course course)
        {
            this.name = name;
            this.age = age;
            this.teacher = teacher;
            this.course = course;
        }
    }
}

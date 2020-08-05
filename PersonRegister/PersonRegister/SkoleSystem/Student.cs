using System;
using System.Collections.Generic;
using System.Text;

namespace SkoleSystem
{
    public class Student
    {
        public string name;
        public int age;
        public Employee teacher;
        public Course course;
        public Student(string name, int age, Employee teacher, Course course)
        {
            this.name = name;
            this.age = age;
            this.teacher = teacher;
            this.course = course;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SkoleSystem
{
    public class Course
    {
        public string name;
        public int roomNum;
        public Employee teacher;
        public List<Student> courseStudents = new List<Student>();
        public Course(string name, int roomNum, Employee teacher, List<Student> courseStudents)
        {
            this.name = name;
            this.roomNum = roomNum;
            this.teacher = teacher;
            this.courseStudents = courseStudents;
        }

        public Course(string name, int roomNum, List<Student> courseStudents)
        {
            this.name = name;
            this.roomNum = roomNum;
            teacher = null;
            this.courseStudents = courseStudents;
        }
    }
}

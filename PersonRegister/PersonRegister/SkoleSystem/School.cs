using System;
using System.Collections.Generic;
using System.Linq;

namespace SkoleSystem
{
    public class School
    {
        public string name;
        public List<Employee> employees = new List<Employee>();
        public School(string name)
        {
            this.name = name;
        }

        public void addStudent(Course course, Student elev)
        {
            course.courseStudents.Add(elev);
        }

        public void removeStudent(Course course, Student elev)
        {
            course.courseStudents.Remove(elev);
        }

        public void addEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void removeEmployee(Employee employee)
        {
            employees.Remove(employee);
        }

        public void addCourse(Course course, string name, int roomNum, Employee teacher)
        {
            Course navn = new Course(name, roomNum, teacher);
            navn.teacher = teacher;
            navn.roomNum = roomNum;
            navn.name = name;
        }

        public void removeCourse(Course course)
        {
            course.teacher = null;
            course.roomNum = 0;
            course.name = null;
        }

        public void ansatteListe()
        {
            for (int i = 0; i < employees.Count(); i++)
            {
                Console.WriteLine($"{employees[i].name} og det hold han har {employees[i].course.name}. Hans løn er betalt: {employees[i].salaryPayed}");
            }
        }
    }
}

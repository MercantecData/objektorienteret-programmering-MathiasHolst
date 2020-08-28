using System;
using System.Collections.Generic;
using System.Linq;

namespace SkoleSystem
{
    public class School
    {
        private string name;
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
            navn.Teacher = teacher;
            navn.RoomNum = roomNum;
            navn.Name = name;
        }

        public void removeCourse(Course course)
        {
            course.Teacher = null;
            course.RoomNum = 0;
            course.Name = null;
        }

        public void ansatteListe()
        {
            for (int i = 0; i < employees.Count(); i++)
            {
                Console.WriteLine($"{employees[i].name} og det hold han har {employees[i].course.Name}. Hans løn er betalt: {employees[i].SalaryPayed}");
            }
        }
    }
}

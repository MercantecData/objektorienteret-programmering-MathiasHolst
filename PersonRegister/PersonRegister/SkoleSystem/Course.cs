using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkoleSystem
{
    public class Course
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int roomNum;
        public int RoomNum
        {
            get { return roomNum; }
            set { roomNum = value; }
        }
        private Employee teacher;
        public Employee Teacher
        {
            get { return teacher; }
            set { teacher = value; }
        }
        public List<Student> courseStudents = new List<Student>();
        
        public Course(string name, int roomNum, Employee teacher)
        {
            this.name = name;
            this.roomNum = roomNum;
            this.teacher = teacher;
        }

        public Course(string name, int roomNum)
        {
            this.name = name;
            this.roomNum = roomNum;
            teacher = null;
        }

        public void elevListe()
        {
            for (int i = 0; i < courseStudents.Count(); i++)
            {
                Console.WriteLine($"{courseStudents[i].name} er på kurset: {courseStudents[i].course.name}");
            }
        }
    }
}

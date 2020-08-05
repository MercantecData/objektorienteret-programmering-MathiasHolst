using System;
using System.Collections.Generic;

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
    }
}

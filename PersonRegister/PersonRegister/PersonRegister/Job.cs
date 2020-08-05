using System;
using System.Collections.Generic;
using System.Text;

namespace PersonRegister
{
    public class Job
    {
        public string jobtitle;
        public string orgName;
        public int salary;

        public Job(string jobtitle, string orgName, int salary)
        {
            this.jobtitle = jobtitle;
            this.orgName = orgName;
            this.salary = salary;
        }

        public Job(string jobtitle, int salary)
        {
            this.jobtitle = jobtitle;
            orgName = "Unknown";
            this.salary = salary;
        }
    }
}

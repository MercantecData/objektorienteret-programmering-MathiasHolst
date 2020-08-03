using System;

namespace PersonRegister
{
    public class person
    {
       public string name;
       public int age;
       public Job job;

       public person(string name, int age, Job job)
       {
            this.name = name;
            this.age = age;
            this.job = job;
       }
    }
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
    }
}

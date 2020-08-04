using System;
using System.Collections.Generic;

namespace PersonRegister
{
    public class Person
    {  
       public string name;
       public int age;
       public Job job;

        public Person(string name, int age, Job job)
       {
            this.name = name;
            this.age = age;
            this.job = job;
       }

       public Person(int age, Job job)
       {
           this.name = "Classified";
           this.age = age;
           this.job = job;
       }
    }
}

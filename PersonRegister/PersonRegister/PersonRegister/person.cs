using System;
using System.Collections.Generic;

namespace PersonRegister
{
    public class Person
    {   
       public string name;
       public int age;
       public Job job;
       public string nationality;

       public Person(string name, int age, Job job, string nationality)
       {
            this.name = name;
            this.age = age;
            this.job = job;
            this.nationality = nationality;
       }

       public Person(int age, Job job, string nationality)
       {
           name = "Classified";
           this.age = age;
           this.job = job;
           this.nationality = nationality;
       }

       public Person(string name, int age, Job job)
        {
            this.name = name;
            this.age = age;
            this.job = job;
            nationality = "Classified";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace PersonRegister
{
    public class RegisterFunktioner
    {
        public List<Person> listOfPeople = new List<Person>();
        public void AddToList(Person name)
        {
            listOfPeople.Add(name);
        }
    }
}

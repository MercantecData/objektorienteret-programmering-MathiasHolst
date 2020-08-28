using System;
using System.Collections.Generic;
using System.Text;

namespace PersonRegister
{
    public class RegisterFunktioner
    {
        public List<Person> listOfPeople = new List<Person>();
        public Dictionary<string, int> navnOgAlderDic = new Dictionary<string, int>();

        public void AddToList(Person name)
        {
            listOfPeople.Add(name);
        }

        public void RemoveFromList(Person name)
        {
            listOfPeople.Remove(name);
        }
    }
}

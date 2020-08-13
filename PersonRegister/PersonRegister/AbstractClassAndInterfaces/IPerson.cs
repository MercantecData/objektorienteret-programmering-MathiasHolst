using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassAndInterfaces
{
    public interface IPerson : IComparable
    {

        public int CompareTo(object obj)
        {
            return 1;
        }
        

    }
}

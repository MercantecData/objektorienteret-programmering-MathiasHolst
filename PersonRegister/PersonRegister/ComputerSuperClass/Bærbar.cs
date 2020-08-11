using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerSuperClass
{
    public class Bærbar : Computer
    {
        public Bærbar(string name, int price, string password) : base(name, price, password, "127.0.0.3")
        {
            this.name = name;
            this.price = price;
            this.password = password;
        }
    }
}

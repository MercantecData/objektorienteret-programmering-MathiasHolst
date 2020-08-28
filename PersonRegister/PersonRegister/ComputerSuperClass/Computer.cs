using System;
using System.Security.Cryptography;

namespace ComputerSuperClass
{
    public class Computer
    {
        public string name;
        protected int price;
        protected string password;
        protected string ipAddress;
        protected bool power;

        public Computer(string name, int price, string password, string ipAddress)
        {
            this.name = name;
            this.price = price;
            this.password = password;
            this.ipAddress = ipAddress;
        }

        public bool powerOn()
        {
            return power = true;
        }

        public bool powerOff()
        {
            return power = false;
        }
    }
}

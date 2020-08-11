using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerSuperClass
{
    public class Mobiltelefeon : Computer
    {
        protected int tlfNummer;
        public Mobiltelefeon(int tlfNummer) : base("IphoneX", 10000, "0000", "127.0.0.4")
        {
            this.tlfNummer = tlfNummer;
        }
    }
}

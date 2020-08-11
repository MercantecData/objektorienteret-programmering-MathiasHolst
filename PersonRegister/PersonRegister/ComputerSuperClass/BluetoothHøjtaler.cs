using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerSuperClass
{
    public class BluetoothHøjtaler : Computer
    {
        protected string bluetoothAdr;

        public BluetoothHøjtaler(string bluetoothAdr) : base ("højtaler", 2000, "dingdong", "127.0.0.1")
        {
            this.bluetoothAdr = bluetoothAdr;
        }
    }
}

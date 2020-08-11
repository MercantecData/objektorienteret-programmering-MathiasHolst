using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassAndInterfaces
{
    public class SupClass2 : AbstractClass, IMathInterface
    {
        int IMathInterface.plus2()
        {
            return 10 + 2;
        }

        int IMathInterface.gange2()
        {
            return 10 * 2;
        }

        int IMathInterface.minus2()
        {
            return 10 - 2;
        }
        public override int AbstractFunc()
        {
            return 2;
        }
    }
}

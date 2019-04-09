using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.MultipleAbstract
{
    //Abstract Class1
    public abstract class MultiAbsClass
    {
        public abstract int AddTwoNumbers(int Num1, int Num2);
        public abstract int MultiplyTwoNumbers(int Num1, int Num2);
    }

    //Abstract Class2
    public abstract class AbsClass2 : MultiAbsClass
    {
        public override int AddTwoNumbers(int Num1, int Num2)
        {
            return Num1 + Num2;
        }
    }


}

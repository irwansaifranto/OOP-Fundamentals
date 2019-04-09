using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.SimpleAbstract
{
    //Creating an Abstract Class
    public abstract class AbsClass
    {
        //A Non abstract method
        public int AddTwoNumbers(int Num1, int Num2)
        {
            return Num1 + Num2;
        }

        //An abstract method, to be
        //overridden in derived class
        public abstract int MultiplyTwoNumbers(int Num1, int Num2);
    }
}

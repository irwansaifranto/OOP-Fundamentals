using Abstract.SimpleAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.SimpleAbstract
{
    public class AbsDerived : AbsClass
    {
        //using override keyword,
        //implementing the abstract method
        //MultiplyTwoNumbers
        public override int MultiplyTwoNumbers(int Num1, int Num2)
        {
            return Num1 * Num2;
        }
    }
}

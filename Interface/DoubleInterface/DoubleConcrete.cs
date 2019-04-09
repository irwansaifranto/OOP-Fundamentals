using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.DoubleInterface
{
    public class DoubleConcrete : AbcInterface, DefInterface
    {
        public void Def()
        {
            Console.WriteLine("This is :: def");
        }

        public void xyz()
        {
            Console.WriteLine("This is :: xyz");
        }
    }
}

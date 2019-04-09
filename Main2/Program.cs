using Interface.SingleInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleInterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello Interfaces");

            SingleConcrete refSample = new SingleConcrete();
            SingleInterface interface1 = new SingleConcrete();
            interface1.xyz();
            refSample.xyz();
            Console.ReadLine();
        }
    }
}

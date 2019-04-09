using Abstract;
using Abstract.SimpleAbstract;
using Interface.DoubleInterface;
using Interface.MultipleInterface;
using Interface.SingleInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abstract
            SimpleAbstract();
            MultipleAbstract();

            // Interface
            SingleInterface();
            DoubleInterface();
            MultipleInterface();
        }

        /// <summary>
        /// This is sample for abstract class
        /// </summary>
        /// <returns></returns>
        public static AbsDerived SimpleAbstract()
        {
            //You can create an
            //instance of the derived class
            AbsDerived calculate = new AbsDerived();

            int added = calculate.AddTwoNumbers(10, 20);
            int multiplied = calculate.MultiplyTwoNumbers(10, 20);
            Console.WriteLine("Added : {0}, Multiplied: {1}", added, multiplied);
            Console.ReadKey();

            return new AbsDerived();
        }

        /// <summary>
        /// this is sample from multiple implementation of multiple abstract
        /// </summary>
        /// <returns></returns>
        public static Abstract.MultipleAbstract.MultiAbsDerived MultipleAbstract()
        {
            //You can create an
            //instance of the multiple derived class
            Abstract.MultipleAbstract.MultiAbsDerived calculate = new Abstract.MultipleAbstract.MultiAbsDerived();

            int added = calculate.AddTwoNumbers(10, 20);
            int multiplied = calculate.MultiplyTwoNumbers(10, 20);
            Console.WriteLine("Added : {0}, Multiplied: {1}", added, multiplied);
            Console.ReadKey();

            return new Abstract.MultipleAbstract.MultiAbsDerived();
        }

        /// <summary>
        /// This is sample from implementation of single interface
        /// </summary>
        /// <returns></returns>
        public static SingleConcrete SingleInterface()
        {
            System.Console.WriteLine("Hello Interfaces");

            SingleConcrete refSample = new SingleConcrete();
            SingleInterface interface1 = new SingleConcrete();
            interface1.xyz();
            refSample.xyz();
            Console.ReadLine();

            return new SingleConcrete();
        }

        /// <summary>
        /// This is sample from double Create
        /// </summary>
        /// <returns></returns>
        public static DoubleConcrete DoubleInterface()
        {
            System.Console.WriteLine("Double Interfaces");

            DoubleConcrete refSample = new DoubleConcrete();

            refSample.Def();
            refSample.xyz();
            Console.ReadLine();

            return new DoubleConcrete();
        }

        /// <summary>
        /// This is sample from MultipleInterface
        /// </summary>
        /// <returns></returns>
        public static MultipleConcrete MultipleInterface()
        {
            System.Console.WriteLine("Multiple Interfaces");

            MultipleConcrete refSample = new MultipleConcrete();

            refSample.pqr();
            refSample.xyz();
            Console.ReadLine();

            return new MultipleConcrete();
        }
    }
}

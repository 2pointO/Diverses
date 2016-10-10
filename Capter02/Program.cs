using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capter02
{
    class Program
    {
        static void Main(string[] args)
        {
            //------Testing methode with an out value as parameter----//
            /* int value;
             MyTest(2, 5, out value);
             Console.WriteLine("The output value is {0}", value);
            // MyTest(2, 3, 5); doesn't compile without the out value argument !!
             Console.ReadLine(); */

            //------Checking integer in bounce of their own limit-----//
            /*int a = 2147483647;
            int b = 2;
            try
            {
                checked
                {
                    Console.WriteLine((a * b).ToString());
                }
            } catch (Exception e)
            {
                Console.WriteLine("Error OVERFLOW");
            }
            Console.ReadLine();*/


        }

        private static void MyTest(int one, int two, out int data)
        {
            data = 10;
        }

    }
   
}

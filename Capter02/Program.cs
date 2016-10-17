using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capter02
{
   /* public class Residence
    {

        public int numberOfBedrooms;
        public bool hasGarage;
        public bool hasGarden;
        public Residence(int numberOfBedrooms)
        {

            this.numberOfBedrooms = numberOfBedrooms;
        }

    }*/
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

            //------Structure Test-------
            /*
            int x = 99;
            System.Int32 y = x + 1;

            Console.WriteLine(y.ToString());
            Console.ReadLine();*/


            /*Residence myHouse = new Residence(2);
            Residence anotherHouse = new Residence(2);

            if (myHouse == anotherHouse)
            {
                Console.WriteLine("They are the same house");
            }
            else
            {
                Console.WriteLine("They are different houses");
            }
            Console.ReadLine();*/

            //-------Parameter über die Referenz dauerhaft ändern , es wird keine Kopie für die Methode verwendet sondern ein Pointer zum Original
            /*
            string myString = "Original value";
            ChangeInput(ref myString);
            Console.WriteLine(myString);
            Console.ReadLine();*/


        }


        /*
        static void ChangeInput(ref string input)
        {
            input = "Changed value";
        }*/

        private static void MyTest(int one, int two, out int data)
        {
            data = 10;
        }

    }
   
}

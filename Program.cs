using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str_equ1 = "Dot net compare";

            string str_equ2 = " .net compare";



            if (String.Equals(str_equ1, str_equ2))

            {

                Console.WriteLine("Both Strings are equal!");

            }

            else

            {

                Console.WriteLine("Both Strings are not equal!");

            }



            Console.ReadLine();
        }
    }
}

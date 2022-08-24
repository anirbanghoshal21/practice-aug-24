using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String str = "My name is Anirban";
            String result = str.ToUpper();
            Console.WriteLine($"Original String  : {str}");
            Console.WriteLine($"Uppercase String : {result}");
            Console.ReadLine();
        }
    }
}

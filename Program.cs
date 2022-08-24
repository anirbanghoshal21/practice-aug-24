using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt1 = new DateTime();
            dt1 = DateTime.Now;
            Console.WriteLine(dt1);
            Console.WriteLine("Day of year "  + dt1.DayOfYear);
            Console.WriteLine("Month=  " + dt1.Month);
            Console.WriteLine("Day=  " + dt1.Day);
            Console.WriteLine("Hour = " + dt1.Hour);
            Console.WriteLine("Minute = " + dt1.Minute);
            Console.WriteLine("Second = " + dt1.Second);
            Console.WriteLine("Millisecond = " + dt1.Millisecond);
            Console.ReadLine();
        }
    }
}

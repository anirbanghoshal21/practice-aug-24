﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Welcome to the world of C# programming";
            string[] s2 = s1.Split(' ');
            foreach (string s3 in s2)
            {
                Console.WriteLine(s3);
                Console.ReadLine();
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo0119
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 6;
            int b = 3;
            int c = 8;
            int d = 9;
            string s1 = "";
            if (a > (d-c+b))
            {
                Console.WriteLine("value is true;");
            }
            else
            {
                Console.WriteLine("value is false;");
            }
            Console.ReadLine();
        }
    }
}

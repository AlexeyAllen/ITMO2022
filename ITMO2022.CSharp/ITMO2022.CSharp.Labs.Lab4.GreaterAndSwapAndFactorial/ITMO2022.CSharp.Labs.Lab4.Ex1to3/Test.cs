﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO2022.CSharp.Labs.Lab4.Ex1to3
{
    public class Test
    {
        public static void Main()
        {
            int f;
            bool ok;

            int x, y;
            int greater;

            Console.WriteLine("Enter first number: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            y = int.Parse(Console.ReadLine());

            greater = Utils.Greater(x, y);
            Console.WriteLine("The greater value is " + greater);

            Console.WriteLine("Before swap: " + x + "," + y);
            Utils.Swap(ref x, ref y);
            Console.WriteLine("After swap: " + x + "," + y);

            Console.WriteLine("Number for factorial:");
            x = int.Parse(Console.ReadLine());

            ok = Utils.Factorial(x, out f);
            if (ok)
            {
                Console.WriteLine("Factorial (" + x + ") = " + f);
            }
            else
            {
                Console.WriteLine("Cannot compute this factorial");
            }

            Console.ReadKey();
        }
    }
}

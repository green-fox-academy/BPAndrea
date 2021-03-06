﻿using System;
using System.Linq;

namespace exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Write a LINQ Expression to get the average value of the odd numbers from the following array:
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            //method syntax:
            var methodResult = n.Where(number => number % 2 != 0).Average();
            System.Console.WriteLine(methodResult);

            //query syntax:
            double queryResult = (from number in n
                                  where number % 2 != 0
                                  select number).Average();
            System.Console.WriteLine(queryResult);

        }
    }
}

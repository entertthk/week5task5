﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {

        Start:
        int userNumber;
        Console.WriteLine("Please enter a number:");
        userNumber = int.Parse(Console.ReadLine());


            if (userNumber > 0)
            {
                Console.WriteLine("User number is positive.");
            }

            else if (userNumber < 0)
            {
                Console.WriteLine("User number is negative.");
            }

            else
            {
                Console.WriteLine("User number is zero.");
            }
        goto Start;
        Console.ReadLine();
        }
    }
}

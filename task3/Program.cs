using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {

        Start:
        int userNumber;
        Console.WriteLine("Please enter a number:");
        userNumber = int.Parse(Console.ReadLine());

            if (userNumber % 2 == 0 )
            {
                Console.WriteLine("User number is even.");
            }
            else
            {
                Console.WriteLine("User number is odd.");
            }

        goto Start;
        Console.ReadLine();
        }
    }
}

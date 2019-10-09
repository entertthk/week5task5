using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {

        Start:
        int userNumber;
        Console.WriteLine("Please enter a number from 1 to 7:");
        userNumber = int.Parse(Console.ReadLine());


        // 1= Mon 2=Tue 3=Wen jne
            if (userNumber  == 1 )
            {
                Console.WriteLine("Its Monday.\n");
            }
            else if (userNumber == 2)
            {
                Console.WriteLine("Its Tuesday.\n");
            }

            else if (userNumber == 3)
            {
                Console.WriteLine("Its Wednesday.\n");
            }
            else if (userNumber == 4)
            {
                Console.WriteLine("Its Thursday.\n");
            }

            else if (userNumber == 5)
            {
                Console.WriteLine("Its Friday.\n");
            }

            else if (userNumber == 6)
            {
                Console.WriteLine("Its Saturday.\n");
            }
            else if (userNumber == 7)
            {
                Console.WriteLine("Its Sunday.\n");
            }

            else
            {
                Console.WriteLine("Its December soon.\n");
            }

            goto Start;
            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {

        Start:
        string userLetter;
        Console.WriteLine("Please enter a letter:");
        userLetter = Console.ReadLine();

            if (userLetter.ToUpper() == "A" || userLetter.ToUpper() == "E" || userLetter.ToUpper() == "I" || userLetter.ToUpper() == "O" || userLetter.ToUpper() == "U" || userLetter.ToUpper() == "Õ" || userLetter.ToUpper() == "Ä" || userLetter.ToUpper() == "Ö" || userLetter.ToUpper() == "Ü" )
            {
                Console.WriteLine($"Entered letter --> {userLetter.ToUpper()} <-- is a vowel. \n");
            }
            else
            {
                Console.WriteLine($"--> {userLetter.ToUpper()} <-- not a vowel, something else! \n");
            }

        goto Start;   
        Console.ReadLine();
        }
    }
}

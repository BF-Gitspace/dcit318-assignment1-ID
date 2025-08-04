using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Ticket_Calculator
    {
        static void Main(string[] args)
        {
            // Creating a Ticket Price Calculator system

            int age;
            const int price = 10;
            const int discountedPrice = 7;
            Console.WriteLine("Hello Welcome to the Grand Theater.");

            while (true)
            {
                Console.WriteLine("\nDo you want to purchase a Ticket. 'y' to proceed | 'n' to quit");
                string choice = Console.ReadLine();

                // This code should break and quit our program when the user enters either n or N

                if (choice.ToLower() == "n")
                {
                    Console.WriteLine("Thank's for passing by");
                    break;
                }
                // This code is to be executed if and only if the console recives y or Y. so any letter would be rejected.

                else if (choice.ToLower() != "y")
                {
                    Console.WriteLine("Invalid input. Enter 'y' or 'Y' to proceed");
                    continue;
                }
                Console.Write("Please enter your age: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out age))
                {
                    Console.WriteLine("Invalid age. Please enter the correct age");
                    continue;
                }

                if (age >= 65)
                {
                    Console.WriteLine($"You qualify for a discount. Your ticket price is GHC{discountedPrice}");
                }
                else if (age <= 12)
                {
                    Console.WriteLine($"You qualify for a discount. Your ticket price is GHC{discountedPrice}");
                }
                else
                {
                    Console.WriteLine($"Your ticket price is GHC{price}");
                }
                Console.WriteLine("Enjoy your movie :)");
            }

            Console.ReadKey();

        }
    }
}

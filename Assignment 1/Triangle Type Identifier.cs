/*                    Task 3                  Assignment 1                11317514  */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Triangle_Type_Identifier
    {
        static void Main(string[] args)
        {
            double side1;
            double side2;
            double side3;

            Console.WriteLine("|| This is the triangle identifier ||");

            // Prompting the user to enter the three sides
            Console.Write("Enter length of side 1: ");
            if (!double.TryParse(Console.ReadLine(), out side1))
            {
                Console.WriteLine("Invalid input. Please enter a valid number for side1.");
                return;
            }

            Console.Write("Enter length of side 2: ");
            if (!double.TryParse(Console.ReadLine(), out side2))
            {
                Console.WriteLine("Invalid input. Please enter a valid number for side2.");
                return;
            }

            Console.Write("Enter length of side 3: ");
            if (!double.TryParse(Console.ReadLine(), out side3))
            {
                Console.WriteLine("Invalid input. Please enter a valid number for side3.");
                return;
            }

            /* Here we would check if the sides figures can form a triangle 
             * Equilateral: where all three sides are equal
             * Isosceles: only two sides are the same.
             * Scalene: No sides are equal.
             So if any of the conditions below finds it self to be true it return our message
             */

            if (side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
            {
                Console.WriteLine("The values entered cannot form a triangle.");
                return;
            }

            // Lets determine the type of triangle
            if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("This is an Equilateral triangle.");
            }
            else if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                Console.WriteLine("This is an Isosceles triangle.");
            }
            else
            {
                Console.WriteLine("This is a Scalene triangle.");
            }

            Console.ReadKey();
        }
    }
}

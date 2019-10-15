using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            string runAgain = "y";

            while (runAgain == "yes" || runAgain == "Yes" || runAgain == "y")
            {
                //input - gets the length, width, and height from the user
                Console.Write("Enter length: ");
                decimal classLength = decimal.Parse(Console.ReadLine());

                Console.Write("Enter width: ");
                decimal classWidth = decimal.Parse(Console.ReadLine());

                Console.Write("Enter Height:");
                decimal classHeight = decimal.Parse(Console.ReadLine());

                //process - calculate the perimeter, area and volume of the room
                decimal roomPerimeter = 2*(classLength + classWidth);
                decimal roomArea = classLength * classWidth;
                decimal roomVolume = roomArea * classHeight;

                //output - display the perimeter, length and volume of the room
                Console.WriteLine("Perimeter: " + roomPerimeter);
                Console.WriteLine("Area: " + roomArea);
                Console.WriteLine("Volume: " + roomVolume);

                //check if we want to loop back
                Console.Write("Continue?(y/n)");
                runAgain = Console.ReadLine();
            }

        }
    }
}

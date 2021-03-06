﻿using System;

namespace RoomDetailGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var cont = "";
            do
            {
                Console.WriteLine("Enter Length: ");
                var lengthInput = Console.ReadLine();
                Console.WriteLine("Enter Width: ");
                var widthInput = Console.ReadLine();
                Console.WriteLine("Enter Height: ");
                var heightInput = Console.ReadLine();

                bool lengthSuccess = float.TryParse(lengthInput, out float length);
                bool widthSuccess = float.TryParse(widthInput, out float width);
                bool heightSuccess = float.TryParse(heightInput, out float height);

                if (!lengthSuccess || !widthSuccess || !heightSuccess)
                {
                    Console.WriteLine("One of your inputs was invalid. Please try again.");
                    Console.WriteLine("");
                    cont = "Y";
                }
                else
                {
                    float area = length * width;
                    float perimeter = 2 * (length + width);
                    float volume = length * width * height;

                    Console.WriteLine($"Area: {area} sqft.");
                    Console.WriteLine($"Perimeter: {perimeter} ft.");
                    Console.WriteLine($"Volume: {volume} cubic ft.");
                    Console.WriteLine("");
                    Console.WriteLine("Continue? (y/n)");
                    cont = Console.ReadLine().ToUpper();
                }                
            } while (cont == "Y");
        }
    }
}

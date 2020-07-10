using System;

namespace RoomDetailGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool proceed = false;
            do
            {
                Console.WriteLine("Enter Length: ");
                var lengthInput = Console.ReadLine();
                Console.WriteLine("Enter Width: ");
                var widthInput = Console.ReadLine();

                bool lengthSuccess = float.TryParse(lengthInput, out float length);
                bool widthSuccess = float.TryParse(widthInput, out float width);

                float area = length * width;
                float perimeter = 2 * (length + width);

                Console.WriteLine($"Area: {area}");
                Console.WriteLine($"Perimeter: {perimeter}");
                Console.WriteLine("");
                Console.WriteLine("Continue? (y/n)");
                string cont = Console.ReadLine().ToUpper();

                if (cont == "Y")
                {
                    proceed = true;
                    Console.WriteLine("");
                }
                else
                {
                    proceed = false;
                }
            } while (proceed == true);
        }
    }
}

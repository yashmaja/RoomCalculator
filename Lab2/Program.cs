using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) {

                Console.Write("Enter length of classroom in feet: ");
                double length = double.Parse(Console.ReadLine());

                Console.Write("Enter width of classroom in feet: ");
                double width = double.Parse(Console.ReadLine());

                Console.Write("Enter height of classroom in feet: ");
                double height = double.Parse(Console.ReadLine());

                double area = length * width;
                double perimeter = (2 * length) + (2 * width);

                double numCan = perimeter / 5;
                double numTiles = area / 5;

                double volume = area * height;

                Console.WriteLine($"\nArea: {area} \nPerimeter: {perimeter} \nVolume: {volume} \nPaint: {numCan} \nCarpet Tiles: {numTiles}");

                Console.Write("\nKeep measuring rooms! Continue? (y/n): ");
                string input = Console.ReadLine();
                Console.WriteLine();

                if (input == "n")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
            }
        }
    }
}

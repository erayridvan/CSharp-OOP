using System;
using System.Linq;

namespace PointInRectangle
{
    public class Program
    {
        static void Main()
        {
            int[] coordinates = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int topLeftX = coordinates[0];
            int topLeftY = coordinates[1];
            int bottomRightX = coordinates[2];
            int bottomRightY = coordinates[3];

            var rectangle = new Rectangle(topLeftY,topLeftX, bottomRightY, bottomRightX);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int[] currentPoint = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

                int firstCoordinate = currentPoint[0];
                int secondCoordinate = currentPoint[1];

                bool check = rectangle.Contains(new Point(firstCoordinate,secondCoordinate));

                Console.WriteLine(check);
            }
        }
    }
}

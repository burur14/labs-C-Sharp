using System;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of array: ");
            int len = Convert.ToInt32(Console.ReadLine());
            Point[] arr = Functions.createArrayOfPoints(len);

            Console.WriteLine("Points: ");
            Functions.printPoints(arr);

            int firstOctantCount = Functions.countFirstOctant(arr);
            Console.WriteLine("Number of points in first octant: " + firstOctantCount);
        }
    }
}

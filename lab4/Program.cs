using System;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three coordinates of 1st Point: ");
            string[] coordsString1 = Console.ReadLine().Split();
            int[] arr1 = Array.ConvertAll(coordsString1, Convert.ToInt32);
            Point p1 = new Point(arr1[0], (int)arr1[1], arr1[2]);

            Console.WriteLine("Enter the first two coordinates of 2nd Point: ");
            string[] coordsString2 = Console.ReadLine().Split();
            int[] arr2 = Array.ConvertAll(coordsString2, Convert.ToInt32);
            Point p2 = new Point(arr2[0], (int)arr2[1]);

            Console.WriteLine("Enter the first coordinate of 3rd Point: ");
            int coord = Convert.ToInt32(Console.ReadLine());
            Point p3 = new Point(coord);

            Console.WriteLine("Your points:");
            Functions.printPoint(p1);
            Functions.printPoint(p2);
            Functions.printPoint(p3);

            Console.WriteLine("Modified point 1:");
            ++p1;
            Functions.printPoint(p1);
            Console.WriteLine("Enter value to add to the second point's p:");
            int value = Convert.ToInt32(Console.ReadLine());
            p2 += value;
            Console.WriteLine("Modified point 2:");
            Functions.printPoint(p2);

            if(p1 == p2) { Console.WriteLine("Point 1 and 2 are equal"); }
            else { Console.WriteLine("Point 1 and 2 are NOT equal"); }

            Console.WriteLine("Distance from Point 3 to the origin: " + p3.getDistance() );
        }
    }
}

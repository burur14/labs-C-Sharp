using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public static class Functions
    {
        public static Point[] createArrayOfPoints(int n)
        {
            Point[] arr = new Point[n];
            
            for(int i = 0;i < n; i++)
            {
                Random rand = new Random();
                int randX = rand.Next(-9, 10);
                int randY = rand.Next(-9, 10);
                int randZ = rand.Next(-9, 10);
                arr[i] = new Point(randX, randY, randZ);
            }

            return arr;
        }

        public static void printPoints(Point[] arr)
        {
            for(int i = 0;i < arr.Length; i++)
            {
                Console.Write((char) (65 + i%26));
                if(i > 25) { Console.Write((int) i / 26); }
                Console.WriteLine("({0}, {1}, {2})", String.Format("{0, 2}", arr[i].X), String.Format("{0, 2}", arr[i].Y), String.Format("{0, 2}", arr[i].Z));
            }
        }

        public static int countFirstOctant(Point[] arr)
        {
            int count = 0;
            foreach(Point point in arr)
            {
                if(point.X > 0 && point.Y > 0 && point.Z > 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}

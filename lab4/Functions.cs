using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public static class Functions
    {
        public static void printPoint(Point point)
        {
            Console.WriteLine("({0}, {1}, {2})", point.getP(), point.getF(), point.getZ());
        }
    }
}

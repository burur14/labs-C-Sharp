using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class Point
    {
        int x;
        int y;
        int z;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Z { get => z; set => z = value; }

        public Point(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}

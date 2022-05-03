using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Point
    {
        private int p;
        private int f;
        private int z;

        public int getP() { return p; }
        public void setP(int p) { this.p = p; }
        public int getF() { return f; }
        public void setF(int f) { this.f = f; }
        public int getZ() { return z; }
        public void setZ(int z) { this.z = z; }
        public Point() { }
        public Point(int p) { 
            this.p = p;
            Random rand = new Random();
            f = rand.Next(0, 360);
            z = rand.Next(-10,10);
        }
        public Point(int p, int f) {
            this.p = p; 
            this.f = f;
            Random rand = new Random();
            z = rand.Next(-10,10);
        }
        public Point(int p, int f, int z) { this.p = p; this.f = f; this.z = z; }

        public static Point operator ++(Point point){

            return new Point(point.p, point.f + 1, point.z);
        }
        public static Point operator +(Point point, int value)
        {
            return new Point(point.p + value, point.f, point.z);
        }
        public static bool operator ==(Point p1,Point p2)
        {
            if(p1.p == p2.p && p1.f == p2.f && p1.z == p2.z)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Point p1, Point p2)
        {
            return !(p1 == p2);
        }

        public double getDistance()
        {
            double x = this.p * Math.Cos(this.f);
            double y = this.p * Math.Sin(this.f);
            double distance = Math.Round(Math.Sqrt(x * x + y * y + z * z),2);
            return distance;
        }
    }
}

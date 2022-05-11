using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public static class Functions
    {
        public static RationalNumber[] createRationalNumbers(int n)
        {
            Random rand = new Random();
            RationalNumber[] arr = new RationalNumber[n];

            for(int i = 0;i < n; i++)
            {
                double value = Math.Round(rand.NextDouble() * 10,2);
                arr[i] = new RationalNumber(value);
            }
            return arr;
        }

        public static ComplexNumber[] createComplexNumbers(int n)
        {
            Random rand = new Random();
            ComplexNumber[] arr = new ComplexNumber[n];

            for(int i = 0;i < n; i++)
            {
                double realPart = Math.Round(rand.NextDouble() * 10, 2);
                double imaginePart = Math.Round(rand.NextDouble() * 10, 2);
                arr[i] = new ComplexNumber(realPart, imaginePart);
            }
            return arr;
        }

        public static void printNumbers(RationalNumber[] arr)
        {
            Console.WriteLine("Rational numbers array: ");
            foreach(var num in arr)
            {
                Console.WriteLine(num.Value);
            }
            Console.WriteLine();
        }
        public static void printNumbers(ComplexNumber[] arr)
        {
            Console.WriteLine("Complex numbers array: ");
            foreach (var num in arr)
            {
                Console.WriteLine(num.getStringNum());
            }
            Console.WriteLine();
        }

        public static void decreaseAll(RationalNumber[] arr, int n)
        {
            foreach(var num in arr)
            {
                num.Value /= n;
            }
        }

        public static void increaseAll(ComplexNumber[] arr, int n)
        {
            foreach(var num in arr)
            {
                num.Value = Math.Round(num.Value * n, 2);
                num.ImaginePart = Math.Round(num.ImaginePart * n, 2);
            }
        }

        public static double getSumOfAbsolutes(RationalNumber[] ratArr, ComplexNumber[] compArr)
        {
            double sum = 0;
            foreach(var num in ratArr)
            {
                sum += num.absolute();
            }
            foreach (var num in compArr)
            {
                sum += num.absolute();
            }
            return sum;
        }
    }
}

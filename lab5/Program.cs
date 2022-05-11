using System;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of rational numbers to create: ");
            int m = Convert.ToInt32(Console.ReadLine());
            RationalNumber[] rationalArr = Functions.createRationalNumbers(m);

            Console.WriteLine("Enter number of complex numbers to create: ");
            int n = Convert.ToInt32(Console.ReadLine());
            ComplexNumber[] complexArr = Functions.createComplexNumbers(n);

            Console.WriteLine("Your arrays: ");
            Functions.printNumbers(rationalArr);
            Functions.printNumbers(complexArr);

            Functions.decreaseAll(rationalArr, 2);
            Functions.increaseAll(complexArr, 3);
            Console.WriteLine("Arrays after modifying: ");
            Functions.printNumbers(rationalArr);
            Functions.printNumbers(complexArr);

            double sumOfAbsolutes = Functions.getSumOfAbsolutes(rationalArr, complexArr);
            Console.WriteLine("Sum of all absolutes: " + sumOfAbsolutes);
        }
    }
}

using System;

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = "((a+b)*c)-d";
            Node root = Functions.GenerateTree(expression);
            Console.WriteLine($"Binary tree for {expression}:");
            Console.WriteLine($"Level #1: {root}\n{Functions.String(root, 2)}");
        }
    }
}

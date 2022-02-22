using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Item[] items = new Item[5];
            Functions.createItems(ref items);

            Console.WriteLine("Enter file's name: ");
            string path = Console.ReadLine() + ".dat";

            Functions.fillFile(path, items);
            Functions.printItems(items);

            Functions.editPrices(ref items);
            Functions.fillFile(path, items);
            Console.Write("\nPrices has been edited");
            Functions.printItems(items);

            Console.WriteLine("\nEnter new file's name: ");
            string newPath = Console.ReadLine() + ".dat";
            Functions.copyToNewFile(items, newPath);

        }
    }
}

using System;
using System.IO;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter file's name: ");
            string name = Console.ReadLine();
            FileStream file = Functions.createFile(name);

            int numberOfLines = 0;
            Functions.fillFile(file, ref numberOfLines);

            int[] numbersOfWords = Functions.getNumberOfWords(file, numberOfLines);
            Console.WriteLine("Number of words in each line: ");
            Functions.printArray(numbersOfWords);

            int[] maxLengths = Functions.getMaxLengths(file, numberOfLines);
            Console.WriteLine("Max lengths of each line: ");
            Functions.printArray(maxLengths);

            Console.WriteLine("Enter result file's name: ");
            string newFileName = Console.ReadLine();
            FileStream newFile = Functions.createFile(newFileName);

            FileStream resultFile = Functions.editFile(file, newFile, numbersOfWords, maxLengths, numberOfLines);

            Console.WriteLine("\nYour input file: ");
            Functions.printFile(file);
            Console.WriteLine("\nYour new file: ");
            Functions.printFile(newFile);
        }
    }
}

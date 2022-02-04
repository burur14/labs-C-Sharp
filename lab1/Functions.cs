using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    static class Functions
    {
        public static FileStream createFile(string name)
        {
            if (File.Exists(name + ".txt"))
            { 
                File.Delete(name + ".txt");
            }

            FileStream file = File.Create(name + ".txt");
            file.Close();
            return file;
        }

        public static void fillFile(FileStream file, ref int count)
        {
            Console.WriteLine("\nEnter 'stop' to stop input");
            string input = Console.ReadLine();
            
            StreamWriter writer = new StreamWriter(file.Name);
            while(input != "stop")
            {
                writer.WriteLine(input);
                input = Console.ReadLine();
                count++;
            }
            writer.Flush();
            writer.Close();
            
        }

        public static void printFile(FileStream file)
        {
            StreamReader reader = new StreamReader(file.Name);
            Console.WriteLine(reader.ReadToEnd());
            reader.Close();
        }

        public static int[] getNumberOfWords(FileStream file, int lines)
        {
            StreamReader reader = new StreamReader(file.Name);
            int[] result = new int[lines];
            
            for(int i = 0;i < lines; i++)
            {
                result[i] = reader.ReadLine().Split(" ").Length;
            }
            reader.Close();
            return result;
        }

        public static void printArray(int[] arr)
        {
            foreach(int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public static int[] getMaxLengths(FileStream file, int lines)
        {
            int[] lengths = new int[lines];
            StreamReader reader = new StreamReader(file.Name);

            for(int i = 0;i < lines; i++)
            {
                string line = reader.ReadLine();
                string[] words = line.Split(" ");
                int maxLength = 0;
                for(int j = 0;j < words.Length; j++)
                {
                    if(words[j].Length > maxLength)
                    {
                        maxLength = words[j].Length;
                    }
                }
                lengths[i] = maxLength;
            }
            reader.Close();
            return lengths;
        }

        public static FileStream editFile(FileStream file, FileStream newFile, int[] numbersOfWords, int[] maxLengths, int linesAmount)
        {
            StreamReader reader = new StreamReader(file.Name);
            string[] lines = new string[linesAmount];
            for(int i = 0;i < linesAmount; i++)
            {
                lines[i] = reader.ReadLine();
            }
            reader.Close();

            
            StreamWriter writer = new StreamWriter(newFile.Name);
            for(int i = 0;i < linesAmount; i++)
            {
                writer.WriteLine(numbersOfWords[i] + " " + lines[i] + " " + maxLengths[i]);
            }
            writer.Flush();
            writer.Close();

            return newFile;
        }
    }
}

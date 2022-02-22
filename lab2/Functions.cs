using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Functions
    {
        public static void createItems(ref Item[] items)
        {
            string[] names = { "Banana", "Bread", "Sprite", "Cans", "Milk" };
            DateTime[] releaseDates = { DateTime.Now, new DateTime(2021, 12, 31), new DateTime(2022, 2, 15), new DateTime(2021, 6, 26), new DateTime(2022, 2, 14) };
            DateTime[] expiryDates = { DateTime.Now.AddDays(10), new DateTime(2022, 1, 7), new DateTime(2022, 9, 15), new DateTime(2077, 2, 28), new DateTime(2022, 2, 18) };
            double[] costs = { 7.5, 14.88, 22.8, 69, 27 };
        
            for(int i = 0;i < items.Length;i++)
            {
                items[i] = new Item(names[i], releaseDates[i], expiryDates[i], costs[i]);
            }
        }

        public static void fillFile(string path, Item[] items)
        {
            try
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create))){
                    
                    foreach(Item item in items)
                    {
                        string itemInfo = String.Format("{0, -9}", item.Name) + String.Format("{0, -12}", item.ReleaseDate.ToString("dd/MM/yyyy")) + String.Format("{0, -12}", item.ExpiryDate.ToString("dd/MM/yyyy")) + String.Format("{0, -4}", item.Cost + Environment.NewLine);
                        var binInfo = Encoding.UTF8.GetBytes(itemInfo);
                        writer.Write(binInfo);
                        
                    }
                    
                    
                    
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void editPrices(ref Item[] items)
        {
            foreach(Item item in items)
            {
                if(item.LifeDuration.Days <= 14)
                {
                    item.Cost = Math.Round(item.Cost * 0.95, 2);
                }else if(item.LifeDuration.Days > 365)
                {
                    item.Cost = Math.Round(item.Cost * 1.03, 2);
                }
            }
        }

        public static void copyToNewFile(Item[] items, string path)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create))) 
            {
                DateTime todayDate = DateTime.Now;
                foreach (Item item in items)
                {
                    if(DateTime.Compare(item.ReleaseDate, new DateTime(todayDate.Year, todayDate.Month, 1)) < 0)
                    {
                        string itemInfo = String.Format("{0, -9}", item.Name) + String.Format("{0, -12}", item.ReleaseDate.ToString("dd/MM/yyyy")) + String.Format("{0, -12}", item.ExpiryDate.ToString("dd/MM/yyyy")) + String.Format("{0, -4}", item.Cost + Environment.NewLine);
                        Console.Write(itemInfo);
                        var binInfo = Encoding.UTF8.GetBytes(itemInfo);
                        writer.Write(binInfo);
                        
                    }
                }
            }
        }

        public static void printItems(Item[] items)
        {
            Console.WriteLine("\nItems: ");
            foreach(Item item in items)
            {
                string itemInfo = String.Format("{0, -9}", item.Name) + String.Format("{0, -12}", item.ReleaseDate.ToString("dd/MM/yyyy")) + String.Format("{0, -12}", item.ExpiryDate.ToString("dd/MM/yyyy")) + String.Format("{0, -4}", item.Cost + Environment.NewLine);
                Console.Write(itemInfo);
            }
        }

    }
}

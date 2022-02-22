using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Item
    {
        string name;
        DateTime releaseDate;
        DateTime expiryDate;
        double cost;
        TimeSpan lifeDuration;
        public string Name { get; set; }
        public DateTime ReleaseDate { get => releaseDate; set => releaseDate = value; }
        public DateTime ExpiryDate { get => expiryDate; set => expiryDate = value; }
        public double Cost { get => cost; set => cost = value; }
        public TimeSpan LifeDuration { get => lifeDuration;}


        public Item(string name, DateTime releaseDate, DateTime expiryDate, double cost)
        {
            this.Name = name;
            this.ReleaseDate = releaseDate;
            this.expiryDate = expiryDate;
            this.cost = cost;
            lifeDuration = expiryDate.Subtract(releaseDate);
        }

        

    }
}

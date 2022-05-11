using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class ComplexNumber : Number
    {
        private double imaginePart;
        public double ImaginePart { get => imaginePart; set => imaginePart = value; }
        
        public ComplexNumber(double real, double imagine)
        {
            Value = real;
            imaginePart = imagine;
        }
        public string getStringNum()
        {
            return Value + " + " + imaginePart + "*i";
        }

        
        public double absolute()
        {
            double abs = Math.Sqrt(imaginePart * imaginePart + Value * Value);
            return Math.Round(abs,2);
        }

        public void increase(double n)
        {
            Value *= n;
            imaginePart *= n;
        }

    }
}

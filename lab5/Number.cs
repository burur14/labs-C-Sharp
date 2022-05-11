using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public  class Number
    {
        private  double value;

        public double Value { get => value; set => this.value = value; }
    
        public void increase(double n) { value *= n; }
        public void decrease(double n) { value /= n; }
        
        public double absolute()
        {
            return Math.Abs(value);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5p1
{
    class Cappa : CoffeeIF
    {
        double price = 3.00;
        public double choose()
        {
            return price;
        }
        
    }
}

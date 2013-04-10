using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5p1
{
    // this is the wrapper
    class Condem : CoffeeIF
    {
        CoffeeIF coffee;
        CondemIF condems;
        double total;
        string input;
        //choose coffee
     

        public Condem(CoffeeIF coffee, string input)
        {
            // TODO: Complete member initialization
            this.coffee = coffee;
            this.input = input;
            total = coffee.choose();
        }

        public double choose()
        {
            
            if (input.Equals("chocolate"))
            {
                condems = new Chocolate();
                total += condems.add(input);// +price;
            }
            else if (input.Equals("cream"))
            {
                condems = new Cream();
                total += condems.add(input);// +price;
            }
            else if (input.Equals("vanilla"))
            {
                condems = new Vanilla();
                total += condems.add(input);// +price;
            }
            else if (input.Equals("out"))
            {
                return total;
            }
            else
                System.Console.WriteLine("Invalid argument choose: chocolate, vanilla, or cream");
            return total;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5p1
{
    class Program
    {
        static void Main(string[] args)
        {
      
            string input;
            CoffeeIF coffee = new Java();
            Boolean done = true ;
            List<CoffeeIF> coffeeArray = new List<CoffeeIF>() ;
            double price = 0;
            System.Console.WriteLine("Choose coffee type and extras. Coffee choices are java, mocha, and cappachino. Extras are vanilla, chocolate, and cream. You can have only one coffee but can have many extras. When you are finished with your order type done. ");
            input = System.Console.ReadLine();
            if (input == "done")
                done = false;
            else
            {
                if (input.Equals("java"))
                {
                    coffee = new Java();
                    price = coffee.choose();
                }
                else if (input.Equals("cappachino"))
                {
                    coffee = new Cappa();
                    price = coffee.choose();
                }
                else if (input.Equals("mocha"))
                {
                    coffee = new Mocha();
                    price = coffee.choose();
                }
                else
                {
                    

                }
            }
            while (done)
            {
                input = System.Console.ReadLine();
                if (input == "done")
                {
                    
                    coffeeArray.Add(coffee);
                    done = false;
                }
                else
                {
                    if (input.Equals("java"))
                    {
                        
                        coffeeArray.Add(coffee);
                        coffee = new Java();
                        price = coffee.choose();
                    }
                    else if (input.Equals("cappachino"))
                    {
                        //coffee = new Condem();
                        coffeeArray.Add(coffee);
                        coffee = new Cappa();
                        price = coffee.choose();
                    }
                    else if (input.Equals("mocha"))
                    {
                        //coffee = new Condem();
                        coffeeArray.Add(coffee);
                        coffee = new Mocha();
                        price = coffee.choose();

                    }
                    else
                    {
                       
                        coffee = new Condem(coffee, input);
                        coffee.choose();

                    }
                }
                
            }
            System.Console.Clear();
            for (int i = 0; coffeeArray.Count>i;i++){
                
                System.Console.Write("Total:    ");
                System.Console.WriteLine(coffeeArray.ElementAt(i).choose());
                 System.Console.WriteLine(" ");
         }
            while (true) ;


        }
    }
}

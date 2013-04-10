using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HW4p1
{
    // Matthew Swenson
    // Archetecture
    // 3/10/2013
 
   
    class Program
    {
        static void Main()
        {
            
            MyMaterial leather = new MyMaterial("leather", 300);
            MyMaterial plastic = new MyMaterial("plastic", 150);
            ColorBox box1 = new ColorBox(leather);
            ColorBox box2 = (ColorBox) box1.Clone();
            box2.Material = plastic;
            Console.WriteLine("box1 material and width");
            Console.WriteLine(box1.Material.getName());
            Console.WriteLine(box1.Width);
            Console.WriteLine("box2 material and width");
            Console.WriteLine(box2.Material.getName());
            Console.WriteLine(box2.Width);
        }
    }
}

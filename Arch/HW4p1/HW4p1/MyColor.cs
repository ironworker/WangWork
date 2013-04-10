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
 
   
    class MyColor : ICloneable

    {
        int red, green, blue;
        public MyColor(int a, int b, int c)
        {
            red = a;
            green = b;
            blue = c;
        }
        public object Clone()
        {
            MyColor newcolor = (MyColor)this.MemberwiseClone();
            return this.MemberwiseClone() ;
        }
    }
}

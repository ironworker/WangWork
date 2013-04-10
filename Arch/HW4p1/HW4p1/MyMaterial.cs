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
 
    
    class MyMaterial
    {
        private string materialName;
        private double cost;
        public MyMaterial(string name, double costs)
        {
            materialName = name;
            cost = costs;
        }
        public string getName()
        {
            return materialName;
        }
        public double getCost()
        {
            return cost;
        }

    }
   
}

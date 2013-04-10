using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5p2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            FoodProcessorEnvironmentIF processor;
            processor = new FoodProcessorEnvironment();
            processor.load("ConcreteFoodProcessorProgram");
        }
    }
}

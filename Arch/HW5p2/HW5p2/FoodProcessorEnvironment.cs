using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5p2
{
    class FoodProcessorEnvironment : FoodProcessorEnvironmentIF
    {

        public void slice(int secs){
            System.Console.WriteLine("slice "+secs+" Seconds");
        }
        public void mix(int secs){
            System.Console.WriteLine("mix " + secs + " Seconds");
        }
        public void shred(int secs){
            System.Console.WriteLine("shred " + secs + " Seconds");
        }
        public void load(String name)
        {
            Type t = Type.GetType("HW5p2."+name);
            Object o = Activator.CreateInstance(t);
            AbstractFoodProcessorProgram prog = (AbstractFoodProcessorProgram)o;
            prog.setEnvironment(this);
            prog.start();

        }
    }
}

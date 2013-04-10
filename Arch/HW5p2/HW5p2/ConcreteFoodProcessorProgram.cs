using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5p2
{
    class ConcreteFoodProcessorProgram : AbstractFoodProcessorProgram
    {
        public override string getName()
        {
            return "hi?"; 
        }

        public override void start()
        {
            int slice = 20;
            int shred = 5;
            int mix = 3;
            getEnvironment().slice(slice);
            getEnvironment().shred(shred);
            getEnvironment().mix(mix);
        }
    }
}

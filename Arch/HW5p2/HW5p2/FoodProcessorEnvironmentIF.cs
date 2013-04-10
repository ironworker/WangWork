using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5p2
{
    interface FoodProcessorEnvironmentIF
    {
        void slice(int secs);
        void shred(int secs);
        void mix(int secs);
        void load(String name);
    }
}

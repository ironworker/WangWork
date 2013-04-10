using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5p2
{
    abstract class AbstractFoodProcessorProgram
    {
        private FoodProcessorEnvironmentIF environment;
        public void setEnvironment(FoodProcessorEnvironmentIF environment)
        {
            this.environment = environment;
        }
        protected FoodProcessorEnvironmentIF getEnvironment()
        {
            return environment;
        }
        public abstract String getName();
        public abstract void start();

    }
}

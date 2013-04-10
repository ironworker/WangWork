using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6
{
    class NumberIn : States
    {
        public States nextState(int evt)
        {
            switch (evt)
            {
                case 1:
                    return this;
                case 2:
                    return this;
                default:
                    throw new SystemException();
            }

        }

        protected void enter()
        {

        }
    }
}

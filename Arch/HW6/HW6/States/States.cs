using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace HW6
{
    abstract class States
    {
        public static int NUM_EVT = 1;
        public static int OP_EVT = 2;

        public static NumberIn numberIn;
        public static Operator op;

        States()
        {
            if (numberIn == null)
            {
                numberIn = new NumberIn();
                op = new Operator();
            }
        }
        public static States start()
        {
            States s = new NumberIn();
            //s.numberIn.enter();
            return s;
        }
        public States nextState(int evt) { throw new System.NotSupportedException(); }
        public States processEvent(int evt)
        {
            States state = nextState(evt);
            if (this != state)
            {
                state.enter();
            }
            return state;
        }
        protected void enter() { }

        
    }
}

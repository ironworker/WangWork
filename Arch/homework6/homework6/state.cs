using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6
{
    abstract class state
    {
        protected static number numberstate;
        protected static oper operatorstate;
        protected static double num;
        protected static char op;
        protected static string ans;
        protected static    string mod;
        public state() { }
        public abstract void  start();
        public abstract void enter(char n);
        public abstract state  processEvent(char n);
        public abstract string setText();




    }
}

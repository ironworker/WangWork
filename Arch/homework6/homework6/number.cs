using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6
{

    
    class number : state
    {
        public number() { }
        public override void enter(char n)
        {
            mod = "0";
            num = 0;
            this.processEvent(n);
            
                
        }
        public override void start(){
           
            mod = "0";
            op = '+';
            numberstate = new number();
            operatorstate = new oper();
            numberstate.enter('0');
          
        }
        public override state processEvent(char n)
        {

            if (n == '0') { num = Convert.ToDouble(num.ToString() + n); }
            else if (n == '1') { num = Convert.ToDouble(num.ToString() + n); }
            else if (n == '2') { num = Convert.ToDouble(num.ToString() + n); }
            else if (n == '3') { num = Convert.ToDouble(num.ToString() + n); }
            else if (n == '4') { num = Convert.ToDouble(num.ToString() + n); }
            else if (n == '5') { num = Convert.ToDouble(num.ToString() + n); }
            else if (n == '6') { num = Convert.ToDouble(num.ToString() + n); }
            else if (n == '7') { num = Convert.ToDouble(num.ToString() + n); }
            else if (n == '8') { num = Convert.ToDouble(num.ToString() + n); }
            else if (n == '9') { num = Convert.ToDouble(num.ToString() + n); }
            else if (n == '.') { num = Convert.ToDouble(num.ToString() + n); }
            else if (n == 'b') { num = Convert.ToDouble(num.ToString().Remove(num.ToString().Length-1)); }
            else exit(n);
            
            return this;
            
            
        }
        public override string setText()
        {
            return num.ToString();
        }
        public void   exit(char n){
            mod =  num.ToString();
            if (ans == null)
            {
                ans = mod;
                mod = "0";
            }
            operatorstate.enter(n);
        }
    }
}

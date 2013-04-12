using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6
{
    
    class oper : state
    {
        static string dumb = "-";
        public oper() { }
        public override void  enter(char n)
        {
            dumb = mod;
            num = 0;
            this.processEvent(n); 
        }
        public override void start()  { }
        public override state  processEvent(char n)
            
        {
            
            //queue();
            if (n == '-')
            {
                op = n;
            }
            else if (n == '+')
            {
                op = n;
            }
            else if (n == '/')
            { 
                op = n;
            }
            else if (n == '=')
            { 
                solve();  
            }
            else if (n == '*') 
            {
                op = n;
            }
            else if (n == 's')
            {
               
                
                num = Math.Sqrt(Convert.ToDouble(ans));
                ans = num.ToString();
            }
            else if (n == 'f')
            {


                num = Convert.ToDouble(ans) * -1;
                ans = num.ToString();
            }
            else if (n == 'i')
            {

                num = 1 / Convert.ToDouble(ans);
                ans = num.ToString();
            }
            else if (n == 'c')
            {
                num = 0;
                ans = num.ToString();
                mod = "0";
                op = '+';
            }
            else if (n == '%') 
            { 
                op = n; 
            }
            else this.exit(n);
            return this;
            
        }
        public override string setText()
        {
            return num.ToString();
        }
        public void  exit(char n)
        {
            
            num = 0;
            numberstate.enter(n);
        }
    
        private void solve(){
            num = Evaluate();
            ans = num.ToString();
        }
        
        
        public static double Evaluate()
        {
            double answer;
            if (op == '+')
                answer = Convert.ToDouble(ans) + Convert.ToDouble(mod);
            else if (op == '-')
                answer = Convert.ToDouble(ans) - Convert.ToDouble(mod);
            else if (op == '/')
                answer = Convert.ToDouble(ans) / Convert.ToDouble(mod);
            else if (op == '*')
                answer = Convert.ToDouble(ans) * Convert.ToDouble(mod);
            else
                answer = Convert.ToDouble(ans) % Convert.ToDouble(mod);
            return answer;


            
        }
    }
}

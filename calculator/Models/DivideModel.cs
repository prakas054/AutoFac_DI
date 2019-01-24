using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace calculator.Models
{
    public class DivideModel
    {
        public int Quo(int a, int b)
        {
            // string s;
            int i;
            try
            {
                i = (a / b);
                
                
            }

            catch(DivideByZeroException e)
            {

                // s = e.Message; 
               i = -1;
            }
            return i;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using calculator.Models;

namespace calculator.Models
{
   public class AddModel : ICalculate
    {
        public int Opera(int a, int b)
        {

            return a + b;

        }
    }
}
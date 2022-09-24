using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Calculat
    {
        public decimal Calculate(string expracssion)
        {
            var numbers = Parsstring(expracssion);
            decimal res = 0;
            for (var i = 0; i < numbers.Length; i++)
            {
                res = res + numbers[i];
            }
            return res;
        }
        private decimal[] Parsstring(string expracssion)
        {
            var perem = expracssion.Split('+');
            var res = new List<decimal>(perem.Length);
            for(var i=0; i<perem.Length; i++)
            {
                if (res.Contains('='))
                {
                    res.AddRenge() 
                }
                var promres = decimal.Parse(perem[i]);
                res.Add(promres);
            }
            return res.ToArray();
        }
        private decimal[] Parsstring(string expracssion)
        {

        }
    }
    
}

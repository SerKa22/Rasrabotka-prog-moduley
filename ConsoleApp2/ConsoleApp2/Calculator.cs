using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Calculat
    {
        public decimal Calculate(string expracssion)
        {
            var numbers = ParsString(expracssion);
            decimal res = 0;
            for (var i = 0; i < numbers.Length; i++)
            {
                res = res + numbers[i];
            }
            return res;
        }
        private decimal[] ParsString(string expracssion)
        {
            var perem = expracssion.Split('+');
            var res = new List<decimal>(perem.Length);
            for (var i = 0; i < perem.Length; i++)
            {
                if (perem[i].Contains("-"))
                {
                    res.AddRange(ParsStringSigned(perem[i]));
                }
                else
                {
                    var promres = decimal.Parse(perem[i]);
                    res.Add(promres);
                }


            }
            return res.ToArray();
        }
        private decimal[] ParsStringSigned(string expracssion)
        {
            var minus = 1;
            var perem = expracssion.Split('-');
            var res = new List<decimal>(perem.Length);
            for (var i = 0; i < perem.Length; i++)
            {
                if (perem[i].Length == 0)
                {
                    minus = -1;
                    continue;
                }
                var promres = decimal.Parse(perem[i]) * minus;
                res.Add(promres);
                minus = -1;
            }
            return res.ToArray();
        }
    }

}

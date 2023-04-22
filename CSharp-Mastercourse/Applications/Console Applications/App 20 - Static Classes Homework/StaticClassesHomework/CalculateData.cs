using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassesHomework
{
    public static class CalculateData
    {
        public static decimal Add(List<decimal> data)
        {
            decimal sum = 0.00M;

            foreach (decimal item in data)
            {
                sum += item;
            }

            return sum;
        }

        public static decimal SubtractFromBalance (decimal inputBalance, decimal inputTotal) 
        {
            return inputBalance - inputTotal;
        }
    }
}

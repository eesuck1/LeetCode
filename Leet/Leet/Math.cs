using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet
{
    internal class Solution
    {
        public static double Pow(double x, int n)
        {
            if (n == 0 || x == 1f) return 1;

            double result = x;

            for (int i = 1; i < Math.Abs(n); i++)
            {
                result *= x;
            }

            if (n < 0)
            {
                return 1 / result;
            }

            return result;
        }
    }
}

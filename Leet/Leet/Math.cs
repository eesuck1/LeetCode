using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet
{
    internal class Math
    {
        public static double Pow(double x, int n)
        {
            if (n == 0 || x == 1f) return 1;

            if (n < 0)
            {
                return 1 / Pow(x, -n);
            }

            double result = x;

            for (int i = 1; i < n; i++)
            {
                result *= x;
            }

            return result;
        }
    }
}

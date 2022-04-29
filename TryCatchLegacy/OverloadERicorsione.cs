using System;
using System.Collections.Generic;


namespace TryCatchLegacy
{
    public class OverloadERicorsione
    {
        public OverloadERicorsione()
        {

        }

        public int Sum(int a, int b) => a + b;

        public double Sum(double c, double d) => c + d;

        public int Sum(string c, string d) => Convert.ToInt32(c) + Convert.ToInt32(d);


        public long Factorial(long a)
        {
            if (a == 1)
                return 1;
            return a * Factorial(a - 1);
        }




    }
}

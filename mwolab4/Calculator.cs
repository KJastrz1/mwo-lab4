using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mwolab4
{
    public class Calculator
    {
        public int AddTwoIntegers(int a, int b)
        {
            if (a < 0 || b < 0)
            {
                throw new ArgumentException("Both integers must be positive.");
            }

            return a + b;
        }
    }
}

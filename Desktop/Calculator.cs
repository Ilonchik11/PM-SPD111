using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop
{
    public class Calculator
    {
        public long Add(long x, long y)
        {
            return x + y;
        }
        public long Subtract(long x, long y)
        {
            return x - y;
        }
        public long Multiply(long x, long y)
        {
            return x * y;
        }
        public double Div(double x, double y)
        {
            if(y == 0)
            {
                throw new DivideByZeroException("Argument 'y' could not be zero");
            }
            return x / y;
        }
    }
}

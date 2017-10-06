using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathToolBox
{
    public class MathToolBoxA : IMathToolBox
    {
        public long Fibonacci(int n)
        {
            if (n < 0)
            {
                throw new InvalidOperationException();
            }

            long a = 0;
            long b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)
            {
                long temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathToolBox
{
    public class MathToolBoxB : IMathToolBox
    {
        public long Fibonacci(int n)
        {
            if (n < 0)
            {
                throw new InvalidOperationException();
            }
            if (n == 0 || n == 1)
                return n;
            return Fibonacci(n - 2) + Fibonacci(n - 1);
        }
    }
}

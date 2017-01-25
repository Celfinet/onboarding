using Cfn.OnBoarding.TDD.MathToolBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cfn.OnBoarding.TDD.MathToolBox.ImplB
{
    public class MathToolBoxB : IMathToolBox
    {
        public int Fibonacci(int n)
        {
            if (n <= 0)
            {
                throw new InvalidOperationException();
            }

            if (n == 1 || n==2)
            {
                return 1;
            }
            return Fibonacci(n - 1) + Fibonacci(n - 2);

        }

    }
}

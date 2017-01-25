using Cfn.OnBoarding.TDD.MathToolBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cfn.OnBoarding.TDD.MathToolBox.ImplA
{
    public class MathToolBoxA : IMathToolBox
    {
        public int Fibonacci(int n)
        {
            if (n <=0)
            {
                throw new InvalidOperationException();
            }

            var a = 0;
            var b = 1;

            for (int i = 0; i < n; i++)
            {
                var temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
    }
}

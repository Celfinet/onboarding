using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cfn.OnBoarding.TDD.StringCalculator
{
    public class NegativeNotAllowedException : Exception
    {
        public NegativeNotAllowedException(string message) : base(message)
        {
        }

    }
}

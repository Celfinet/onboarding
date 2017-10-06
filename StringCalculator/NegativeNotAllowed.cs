using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class NegativeNotAllowedException : Exception
    {
        public NegativeNotAllowedException(string error) : base(error)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cfn.OnBoarding.TDD.StringCalculator
{
    public class StringCalculator : IStringCalculator
    {
        public int Add(string number)
        {
            if (number.Length == 0)
            {
                return 0;
            }

            if (number.Length == 1)
            {
                return int.Parse(number);
            }
            return number.Split(',').ToList().ConvertAll(int.Parse).Aggregate(0, (i, acc) => acc += i);

        }
    }
}

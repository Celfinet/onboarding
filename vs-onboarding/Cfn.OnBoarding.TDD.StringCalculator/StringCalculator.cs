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
            var delimiters = new List<char> { ',', '\n' };
            if (number.Length == 0)
            {
                return 0;
            }

            if (number.Length == 1)
            {
                return int.Parse(number);
            }
            if ("//".Equals(number[0].ToString() + number[1].ToString()))
            {
                var pos = 0;
                for (int i = 0; i < number.Length; i++)
                {
                    if ('\n'.Equals(number[i]))
                    {
                        pos = i;
                        break;
                    }
                }
                delimiters.Add(number[pos - 1]);
                var length = number.Length - (pos + 1);
                number = number.Substring(pos + 1, length);
            }
            return number.Split(delimiters.ToArray()).ToList().ConvertAll(int.Parse).Aggregate(0, (i, acc) => acc += i);

        }
    }
}

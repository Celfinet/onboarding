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
            var xpto = number;
            var delimiters = new List<string> { ",", "\n" };
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
                var posF = 0;
                string dl;
                for (int i = 0; i < number.Length; i++)
                {
                    if ('\n'.Equals(number[i]))
                    {
                        posF = i;
                        break;
                    }
                }
                if ("[".Equals(number[2].ToString()))
                {
                    dl = number.Substring(3, (posF - 2) - 2);
                }
                else
                {
                    dl = number[posF - 1].ToString();
                }
                delimiters.Add(dl);
                var length = number.Length - (posF + 1);
                number = number.Substring(posF + 1, length);
            }

            var lNumbers = number.Split(delimiters.ToArray(), StringSplitOptions.None).ToList().ConvertAll(int.Parse);
            var lNegNumbers = lNumbers.Where(x => x < 0).ToList();

            if (lNegNumbers.Any())
            {
                var strError = "negative not allowed: " + lNegNumbers.ConvertAll(x => x.ToString()).Aggregate("", (i, acc) => acc += i + ";");
                throw new NegativeNotAllowedException(strError);
            }
            lNumbers = lNumbers.Where(x => x > 0 && x < 1000).ToList();
            return lNumbers.Aggregate(0, (i, acc) => acc += i);

        }
    }
}

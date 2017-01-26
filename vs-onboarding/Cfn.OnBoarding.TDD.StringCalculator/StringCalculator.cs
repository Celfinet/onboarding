using System;
using System.Collections.Generic;
using System.Linq;

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
                var countDl = 0;
                var dic = new Dictionary<int, int>();
                for (int i = 0; i < number.Length; i++)
                {
                    if ('['.Equals(number[i]))
                    {
                        countDl = i;
                    }
                    else if (']'.Equals(number[i]))
                    {
                        dic.Add(countDl, i);
                    }
                    else if ('\n'.Equals(number[i]))
                    {
                        posF = i;
                        break;
                    }
                }
                if (dic.Any())
                {
                    foreach (var item in dic)
                    {
                        delimiters.Add(number.Substring(item.Key + 1, (item.Value - 1) - item.Key));
                    }
                }
                else
                {
                    delimiters.Add(number[posF - 1].ToString());
                }
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
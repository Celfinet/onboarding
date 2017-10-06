using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class Calculator
    {
        public int Add(string numbers)
        {
            int result = 0;
            if (numbers == null || numbers.Length == 0) return 0;

            string[] arr;
            if (numbers.StartsWith("//") && numbers.Contains("\n"))
            {

                int index = numbers.IndexOf('\n');
                string delimiter = numbers.Substring(2, 1);
                if(delimiter.Length!=1) throw new InvalidOperationException();
                numbers = numbers.Substring(index + 1);

                if (!Regex.Match(numbers, String.Format("^(((-?[0-9])+[{0}])*(-?[0-9])+)$",delimiter)).Success) throw new InvalidOperationException();

                if (Regex.Match(numbers, "^(-?[0-9])+$").Success)
                {
                    return Convert.ToInt32(numbers);
                }
                arr = numbers.Split(delimiter.ToCharArray()[0]);
             
            }
            else
            {
                if (!Regex.Match(numbers, "^(((-?[0-9])+[,\n])*(-?[0-9])+)$").Success) throw new InvalidOperationException();

                if (Regex.Match(numbers, "^(-?[0-9])+$").Success)
                {
                    return Convert.ToInt32(numbers);
                }
                numbers = numbers.Replace("\n", ",");
                arr = numbers.Split(',');
            }

            int[] numbersArr = Array.ConvertAll(arr, int.Parse);
            if (numbersArr.Where(a => a < 0).Count() > 0)
            {
                string listOfNegative = String.Join(";", numbersArr.Where(a => a < 0).ToArray());
                throw new NegativeNotAllowedException(String.Format("negatives not allowed - {0}", listOfNegative));
            }
            foreach (int a in numbersArr)
            {
                if (a > 1000) continue;
                result += a;
            }


            return result;
        }
    }
}

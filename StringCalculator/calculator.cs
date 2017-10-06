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
                string delimiter = numbers.Substring(2, index-2);
                numbers = numbers.Substring(index + 1);
                if (delimiter.Length > 1)
                {
                    string[] arrDelimiters = delimiter.Split(']'); // [; [% [&
                    for(int i = 0; i < arrDelimiters.Length; i++)
                    {
                        if (arrDelimiters[i].Length >0) {
                            arrDelimiters[i] = arrDelimiters[i].Substring(1);
                            numbers = numbers.Replace(arrDelimiters[i], ";");
                        }

                    }

                }

                if (!Regex.Match(numbers, "^(((-?[0-9])+;)*(-?[0-9])+)$").Success) throw new InvalidOperationException();

                if (Regex.Match(numbers, "^(-?[0-9])+$").Success)
                {
                    return Convert.ToInt32(numbers);
                }
                arr = numbers.Split(';');
             
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

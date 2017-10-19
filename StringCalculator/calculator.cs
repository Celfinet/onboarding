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


            if (inputHasDelimiters(numbers))
                numbers = escapeDelimiters(numbers);

            numbers = numbers.Replace("\n", ",");
            if (isNotOnlyNumbersSeparatedByComma(numbers))
                throw new InvalidOperationException();
            
            int[] numbersArr =parseToArrayOfNumbers(numbers);

            if (numbersArr.Where(a => a < 0).Count() > 0)
            {
                string negativesSeparatedByCommas = String.Join(";", numbersArr.Where(a => a < 0).ToArray());
                throw new NegativeNotAllowedException(String.Format("negatives not allowed - {0}", negativesSeparatedByCommas));
            }
            foreach (int a in numbersArr)
            {
                if (a > 1000) continue;
                result += a;
            }
            return result;
        }

        public bool inputHasDelimiters(string input)
        {
            return input.StartsWith("//") && input.Contains("\n");
        }

        public string escapeDelimiters(string numbers)
        {
            int indexOfNewLine = numbers.IndexOf('\n');
            string delimiter = numbers.Substring(2, indexOfNewLine - 2);
            numbers = numbers.Substring(indexOfNewLine + 1);
            if (delimiter.Length > 0)
            {
                string[] arrDelimiters = delimiter.Split(']');
                // [; [% [&
                for (int i = 0; i < arrDelimiters.Length; i++)
                {
                    if (arrDelimiters[i].Length == 0) continue;
                    if (arrDelimiters[i].Length > 1) 
                        arrDelimiters[i] = removeBracket(arrDelimiters[i]);
                    numbers = numbers.Replace(arrDelimiters[i], ",");
                }

            }
            return numbers;
        }

        public bool isNotOnlyNumbersSeparatedByComma(string inputString)
        {
            return !Regex.Match(inputString, "^(((-?[0-9])+,)*(-?[0-9])+)$").Success;
        }

        public string removeBracket(string input)
        {
            return input.Substring(1);
        }

        public int[] parseToArrayOfNumbers(string numbers)
        {
            string[] arrayToSome = numbers.Split(',');
            return Array.ConvertAll(arrayToSome, int.Parse);
        }
    }
}

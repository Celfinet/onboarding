using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public static class XptoExtension
    {
        public static int MySum(this IEnumerable<int> arr)
        {
            var sum = 0;
            foreach (var i in arr)
            {
                sum += i;
            }
            return sum;
        }
        public static string Shout<TType>(this TType a, string b)
        {
            return $"{b} {a}";
        }
    }
}

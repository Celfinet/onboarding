using Example;
using System.Collections.Generic;

namespace Example
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var arr = new[] { 1, 2, 3 };
            var list = new List<int> { 1, 2, 3, 4 };
            var sum = XptoExtension.Shout(XptoExtension.MySum(arr), "rofl");
            var sum2 = arr.MySum().Shout("rofl");
            int a = 3;
            a.Shout("b");
            list.MySum().Shout("AD");

            "wewew".Shout("123");
        }
    }
}
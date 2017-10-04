using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Modified
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');
            int[] arrInt = Array.ConvertAll(arr, int.Parse);
            switch (arrInt[2])
            {
                case 1:
                    Console.WriteLine(arrInt[0]);
                    break;
                case 2:
                    Console.WriteLine(arrInt[1]);
                    break;
                default:
                    Console.WriteLine(FibonnaciModified(arrInt[0], arrInt[1], arrInt[2], 3).ToString());
                    break;
            }
            Console.ReadLine();
        }

        private static int FibonnaciModified(int ti, int ti1, int n, int current)
        {
            if (current == n) return ti + ti1 * ti1;
            return FibonnaciModified(ti1, ti + ti1 * ti1, n, current + 1);
        }
    }
}

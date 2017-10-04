using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximize_XOR
{
    class Program
    {
        static void Main(string[] args)
        {
            int L = Convert.ToInt32(Console.ReadLine());
            int R = Convert.ToInt32(Console.ReadLine());
            
            int max = 0;
            for (int i = L; i < R-1; i++)
            {
                for (int j = i+1; j < R; j++)
                {
                    int xor = j ^ i;
                    if (xor > max)
                    {
                        max = xor;
                    }
                }
            }
            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}

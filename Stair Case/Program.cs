using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stair_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 0;

            if (int.TryParse(Console.ReadLine(), out length))
            {
                for (int i= 1; i <= length; i++)
                {
                    Console.WriteLine(new string(' ', length - i) + new string('#', i));
                }
            }
            Console.ReadLine();
        }
    }
}
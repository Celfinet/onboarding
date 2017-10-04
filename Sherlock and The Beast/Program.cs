using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sherlock_and_The_Beast
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            StringBuilder result = new StringBuilder("");
            do
            {
                int N = Convert.ToInt32(Console.ReadLine());

                int number5 = N, number3 = 0;
                bool found=false;
                while (!found && number5>0)
                {
                    if (number5 % 3 == 0 && number3 == 0 && number5 == N) found = true;
                    if (number3 % 5 == 0 && number5 == 0 && number3 == N) found = true;
                    if (number3 % 5 == 0 && number5 % 3 == 0) found = true;
                    if (!found)
                    {
                        number5--;
                        number3++;
                    }
                }
                if (number5 == -1)
                {
                    result.AppendLine("-1");
                }
                else
                {
                    result.AppendFormat("{0}{1}\n", new string('5', number5), new string('3', number3));
                }
                count++;
            } while (count < T);
            Console.Write(result.ToString());
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Array_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int length=0;

            if(int.TryParse(Console.ReadLine(), out length))
            {
                string[] arrStr = Console.ReadLine().Split(' ');
                int[] arrInt = Array.ConvertAll(arrStr, int.Parse);
                int sum = 0;
                for(int i = 0; i < length && i<arrInt.Length; i++)
                {
                    sum += arrInt[i];                    
                }
                Console.WriteLine(sum);
                Console.ReadLine();
            }


        }
    }
}

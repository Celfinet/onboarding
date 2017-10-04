using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chocolate_Feast
{
    class Program
    {
        static void Main(string[] args)
        {
            if (int.TryParse(Console.ReadLine(), out int T))
            {
                int count = 0;
                int[] results = new int[T];
                do
                {
                    string[] input_values = Console.ReadLine().Split(' ');
                    int budget = Convert.ToInt32(input_values[0]);
                    int unitPrice = Convert.ToInt32(input_values[1]);
                    int packageAmmount = Convert.ToInt32(input_values[2]);
                    int unitsbought = budget / unitPrice;

                    int chocolatesWithoutPackage = unitsbought / packageAmmount * packageAmmount;
                    int chocolatesWithPackage = unitsbought % packageAmmount + unitsbought / packageAmmount;


                    results[count] = chocolatesWithoutPackage + chocolatesWithPackage + chocolatesWithPackage/ packageAmmount;
                    
                    count++;
                } while (count < T);

                foreach (int result in results)
                {
                    Console.WriteLine(result);
                }
                Console.ReadLine();
            }

        }
    }
}

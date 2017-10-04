using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtopianTree
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder result = new StringBuilder("");


            if (int.TryParse(Console.ReadLine(), out int length))
            {
                int count = 0;
                while (count < length)
                {
                    if (int.TryParse(Console.ReadLine(), out int cycles))
                    {
                        int treeheight = 1;
                        for(int i = 1; i <= cycles; i++)
                        {
                            if (i % 2 == 0)
                            {
                                treeheight += 1;
                            }
                            else
                            {
                                treeheight *=2;
                            }
                        }
                        result.AppendLine(treeheight.ToString());
                    }
                    count++;
                }
            }
            Console.Write(result);
            Console.ReadLine();

        }
    }
}

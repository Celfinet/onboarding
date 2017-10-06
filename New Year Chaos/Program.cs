using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Year_Chaos
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            StringBuilder strResults = new StringBuilder("");
            for (int cases = 0; cases < testCases; cases++)
            {
                int peopleInQueue= Convert.ToInt32(Console.ReadLine());
                string[] strQueue = Console.ReadLine().Split(' ');
                List<int> queue = Array.ConvertAll(strQueue, int.Parse).ToList();
                int bribes = 0;
                for(int index = peopleInQueue-1; index >=0; index--)
                {
                    int positionOfIndex = queue.IndexOf(index+1);
                    if (index-positionOfIndex  > 2)
                    {
                        strResults.AppendLine("Too chaotic");
                        break;
                    }
                    if (index - positionOfIndex> 0)
                    {
                        bribes += index- positionOfIndex;
                        queue.Remove(index+1);
                        queue.Insert(index, index + 1);
                    }
                    if (index == 0)
                    {
                        strResults.AppendLine(bribes.ToString());
                    }
                }
            }
            Console.Write(strResults);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missing_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> AList = new List<string>(), BList = new List<string>(), missList = new List<string>();
            StringBuilder missingNumbers = new StringBuilder("");
            if (int.TryParse(Console.ReadLine(), out int sizeA))
            {
                AList = Console.ReadLine().Split(' ').ToList();
            }

            if (int.TryParse(Console.ReadLine(), out int sizeB))
            {
                BList = Console.ReadLine().Split(' ').ToList();
            }

            foreach (string str in BList)
            {
                BList.Where(a => a.Equals(str));
                if (BList.Count(a => a.Equals(str)) != AList.Count(a => a.Equals(str)) && !missList.Contains(str))
                {
                    missingNumbers.AppendFormat("{0} ", str);
                    missList.Add(str);
                }
            }
            Console.WriteLine("Missing numbers:{0}", missingNumbers);
            Console.ReadLine();
        }
    }
}

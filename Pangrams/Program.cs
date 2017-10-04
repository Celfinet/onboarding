using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pangrams
{
    class Program
    {
        static void Main(string[] args)
        {

            string inputStr;
            do
            {
                inputStr = Console.ReadLine();
                inputStr = inputStr.ToUpper();
                bool notPangram = false;
                for(int chr = 65; chr <= 90; chr++)
                {
                    if (inputStr.IndexOf(((char)chr))==-1)
                    {
                        notPangram = true;
                    }
                }
                Console.WriteLine(notPangram? "Not pangram":"pangram");
            } while (!inputStr.Equals("N"));
        }
    }
}

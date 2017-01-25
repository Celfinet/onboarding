using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;



class Solution
{


    public static void Main(string[] argv)
    {
        const int N_FIVE_DIGITS = 3;
        const int N_THREE_DIGITS = 5;

        int nCases, nCase, blocksOfFive, blocksOfTree, remainingDigitSpace;
        nCases = Convert.ToInt32(Console.ReadLine());
        while (nCases-- != 0)
        {
            nCase = Convert.ToInt32(Console.ReadLine());
            blocksOfFive = nCase / N_FIVE_DIGITS;
            remainingDigitSpace = nCase - (blocksOfFive * N_FIVE_DIGITS);
            while (remainingDigitSpace % N_THREE_DIGITS != 0 && blocksOfFive != 0)
            {
                blocksOfFive--;
                remainingDigitSpace += N_FIVE_DIGITS;
            }
            if (remainingDigitSpace % N_THREE_DIGITS != 0)
            {
                Console.WriteLine("-1");
            }
            else
            {
                blocksOfTree = remainingDigitSpace / N_THREE_DIGITS;
                for (int i = 0; i < blocksOfFive; i++)
                {
                    Console.Write("555");
                }
                for (int i = 0; i < blocksOfTree; i++)
                {
                    Console.Write("33333");
                }
                Console.WriteLine();
            }
        }
    }
}

//using System;
//using System.Linq;
//using System.Numerics;
//using static System.Console;
//using static System.Convert;

//internal class Solution
//{
//    private static void Main(String[] args)
//    {
//        int t = Convert.ToInt32(ReadLine());
//        for (int a0 = 0; a0 < t; a0++)
//        {
//            int n = ToInt32(ReadLine());
//            if (!MF(n, 0))
//            {
//                WriteLine(-1);
//            }
//        }
//    }

//    public static Boolean MF(int n, BigInteger y)
//    {
//        if (n == 0)
//        {
//            if (!IsDecentNumber(y))
//                return false;
//            WriteLine(y);
//            return true;
//        }
//        if (MF(n - 1, (y * 10) + 5))
//            return true;
//        else if (MF(n - 1, (y * 10) + 3))
//            return true;
//        return false;
//    }

//    public static Boolean IsDecentNumber(BigInteger num)
//    {
//        if ((countNumbers(num, 3) % 5 == 0)
//            && (countNumbers(num, 5) % 3 == 0))
//            return true;
//        return false;
//    }

//    public static long countNumbers(BigInteger num, int countN)
//    {
//        return num.ToString().ToList().Where(x => BigInteger.Parse(x.ToString()) == countN).ToList().Count;
//    }
//}
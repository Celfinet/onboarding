using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using static System.Console;
using static System.Convert;

internal class Solution
{
    private static void Main(String[] args)
    {
        var l1 = ReadLine().Split(' ').Select(x => ToInt32(x)).ToList();
        var lF = new List<BigInteger>();
        lF.Add(l1[0]);
        lF.Add(l1[1]);
        int n = l1[2];
        for (int i = 2; i < n; i++)
        {
            BigInteger aux = lF[i - 2] + lF[i - 1] * lF[i - 1];
            lF.Add(aux);
        }
        WriteLine(lF[n - 1]);
    }
}
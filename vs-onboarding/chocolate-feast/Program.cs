using System;
using static System.Console;
using static System.Convert;

internal class Solution
{
    private static void Main(String[] args)
    {
        int t = ToInt32(ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            string[] tokens_n = ReadLine().Split(' ');
            int n = ToInt32(tokens_n[0]);
            int c = ToInt32(tokens_n[1]);
            int m = ToInt32(tokens_n[2]);
            int counter = n / c;
            int w = counter;
            while (w >= m)
            {
                var d = w / m;
                var r = w % m;
                w = r + d;
                counter += d;
            }
            WriteLine(counter);
        }
    }
}
using System;

internal class Solution
{
    private static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                Console.Write(j < n - (i - 1) ? " " : "#");
            }
            Console.WriteLine();
        }
    }
}
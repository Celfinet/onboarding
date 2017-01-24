using System;

internal class Solution
{
    private static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int tree = 1;
            for (int i = 1; i <= n; i++)
            {
                tree = (i % 2 == 0 ? tree + 1 : tree * 2);
            }
            Console.WriteLine(tree);
        }
    }
}
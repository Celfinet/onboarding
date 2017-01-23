using System;
using System.Linq;

internal class Solution
{
    private static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arrTemp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arrTemp, Int32.Parse);
        int sum = arr.Sum();

        Console.Out.Write(sum);
    }
}
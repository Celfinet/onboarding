using System;
using System.Linq;

internal class Solution
{
    private static void Main(string[] args)
    {
        string abc = "abcdefghijklmnopqrstuvwxyz";
        var abcList = abc.ToList();
        var charArr = Console.ReadLine().Trim(' ').ToLower().ToCharArray();
        foreach (var item in charArr)
        {
            for (int i = 0; i < abcList.Count; i++)
                if (abcList.Contains(item))
                    abcList.Remove(item);
            if (abcList.Count == 0)
                break;
        }
        if (abcList.Count == 0)
            Console.WriteLine("pangram");
        else Console.WriteLine("not pangram");
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using static System.Convert;

internal class Solution
{
    private static void Main(String[] args)
    {
        int n1 = ToInt32(ReadLine());
        var l1 = ReadLine().Split(' ').Select(x => ToInt32(x)).ToList();
        var dic1 = GetDictionary(l1);

        int n2 = ToInt32(ReadLine());
        var l2 = ReadLine().Split(' ').Select(x => ToInt32(x)).ToList();
        var dic2 = GetDictionary(l2);

        var finalList = new List<int>();
        foreach (var item in dic1)
        {
            if (dic2.ContainsKey(item.Key))
            {
                int dif = dic2[item.Key] - item.Value;
                dic2.Remove(item.Key);
                if (dif != 0)
                {
                    finalList.Add(item.Key);
                }
            }
        }
        finalList.Sort();
        foreach (var item in finalList)
            Write($"{item} ");
    }

    private static Dictionary<int, int> GetDictionary(List<int> l)
    {
        var dic = new Dictionary<int, int>();
        foreach (var item in l)
        {
            if (dic.ContainsKey(item))
            {
                dic[item] += 1;
            }
            else dic.Add(item, 1);
        }
        return dic;
    }
}
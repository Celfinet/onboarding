using System;
using System.Collections.Generic;
using static System.Console;
using static System.Convert;

class Solution
{

    static void Main(string[] args)
    {
        var T = ToInt32(ReadLine());
        for (int a0 = 0; a0 < T; a0++)
        {
            var n = ToInt32(ReadLine());
            var q_temp = ReadLine().Split(' ');
            var q = Array.ConvertAll(q_temp, Int32.Parse);
            var dic = new Dictionary<int, int>();
            var bribes = 0;
            var flag = false;
            while (bribes != -1 && flag == false)
            {
                flag = true;
                for (int i = 0; i < q.Length - 1; i++)
                {
                    var j = i + 1;
                    if (q[i] > q[j])
                    {
                        flag = false;
                        if (dic.ContainsKey(q[i]))
                        {
                            if (dic[q[i]] >= 2)
                            {
                                bribes = -1;
                                WriteLine("Too chaotic");
                                break;
                            }
                            dic[q[i]]++;
                        }
                        else dic.Add(q[i], 1);
                        Swap(q, i, j);
                    }
                }
            }
            if (bribes != -1)
            {
                bribes = CountBribes(dic);
                WriteLine(bribes);
            }
        }
    }
    private static void Swap(int[] q, int i, int j)
    {
        var aux = q[i];
        q[i] = q[j];
        q[j] = aux;
    }
    private static int CountBribes(Dictionary<int, int> dic)
    {
        var aux = 0;
        foreach (var item in dic)
        {
            aux += item.Value;
        }
        return aux;
    }
}

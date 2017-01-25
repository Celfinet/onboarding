using System;
using System.Collections.Generic;
using static System.Console;
using static System.Convert;

class Solution
{

    static void Main(String[] args)
    {
        int T = ToInt32(ReadLine());
        for (int a0 = 0; a0 < T; a0++)
        {
            int n = ToInt32(ReadLine());
            string[] q_temp = ReadLine().Split(' ');
            int[] q = Array.ConvertAll(q_temp, Int32.Parse);
            var dic = new Dictionary<int, int>();
            int bribes = 0;
            //    for (int i = 0; i < q.Length - 1; i++)
            //    {
            //        int j = i + 1;
            //        if (q[i] > q[j])
            //        {
            //            if (dic.ContainsKey(q[i]))
            //            {
            //                if (dic[q[i]] >= 2)
            //                {
            //                    WriteLine("Too chaotic");
            //                    break;
            //                }
            //                dic[q[i]]++;
            //            }
            //            else dic.Add(q[i], 1);
            //            Swap(q,i,j);

            //        }

            //    }
            //}
            if (bribes != -1)
                WriteLine(bribes);
        }

    }
    private static void Swap(int[] q, int a, int b)
    {
        int aux = q[a];
        q[a] = q[b];
        q[b] = a;
    }
}
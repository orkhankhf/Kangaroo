using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static string kangaroo(int x1, int v1, int x2, int v2)
    {
        int birinci = x1;
        int ikinci = x2;
        string result = "NO";
        for (int a = 0; a < 10001; a++)
        {
            birinci = birinci + v1;
            ikinci = ikinci + v2;
            if (birinci == ikinci)
            {
                result = "YES";
                break;
            }
        }
        return result;
    }

    static void Main(String[] args)
    {
        string[] tokens_x1 = Console.ReadLine().Split(' ');
        int x1 = Convert.ToInt32(tokens_x1[0]);
        int v1 = Convert.ToInt32(tokens_x1[1]);
        int x2 = Convert.ToInt32(tokens_x1[2]);
        int v2 = Convert.ToInt32(tokens_x1[3]);
        string result = kangaroo(x1, v1, x2, v2);
        Console.WriteLine(result);
    }
}

using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int N, int number) {
        if (N == number) return 1;

        List<HashSet<int>> dp = new List<HashSet<int>>();
        for (int i = 0; i <= 8; i++)
            dp.Add(new HashSet<int>());

        int concat = 0;

        for (int i = 1; i <= 8; i++)
        {
            concat = concat * 10 + N;
            dp[i].Add(concat);

            for (int j = 1; j < i; j++)
            {
                foreach (int a in dp[j])
                {
                    foreach (int b in dp[i - j])
                    {
                        dp[i].Add(a + b);
                        dp[i].Add(a - b);
                        dp[i].Add(a * b);
                        if (b != 0)
                            dp[i].Add(a / b);
                    }
                }
            }

            if (dp[i].Contains(number))
                return i;
        }

        return -1;
    }
}

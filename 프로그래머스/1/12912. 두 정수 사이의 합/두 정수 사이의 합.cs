using System;
using System.Linq;

public class Solution {
    public long solution(int a, int b) {
        long min = Math.Min(a, b);
        long max = Math.Max(a, b);

        long count = max - min + 1;
        return (min + max) * count / 2;
    }
}

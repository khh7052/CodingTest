using System;
using System.Linq;

public class Solution {
    public int solution(int[] queue1, int[] queue2) {
        long sum1 = 0, sum2 = 0;
        foreach (int x in queue1) sum1 += x;
        foreach (int x in queue2) sum2 += x;

        long total = sum1 + sum2;
        if (total % 2 != 0) return -1;

        long target = total / 2;

        int n = queue1.Length;
        int[] arr = new int[n * 2];
        for (int i = 0; i < n; i++) arr[i] = queue1[i];
        for (int i = 0; i < n; i++) arr[i + n] = queue2[i];

        int left = 0;
        int right = n;
        long current = sum1;
        int count = 0;
        int limit = n * 3;

        while (count <= limit)
        {
            if (current == target) return count;

            if (current < target) {
                current += arr[right % arr.Length];
                right++;
            }
            else {
                current -= arr[left];
                left++;
            }

            count++;
        }

        return -1;
    }
}

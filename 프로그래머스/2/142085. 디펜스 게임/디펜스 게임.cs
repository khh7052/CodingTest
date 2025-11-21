using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int n, int k, int[] enemy) {
        int total = 0;
        SortedList<int, int> sorted = new SortedList<int, int>();

        for (int i = 0; i < enemy.Length; i++) {
            int e = enemy[i];
            total += e;

            // 중복 처리
            if (sorted.ContainsKey(e)) sorted[e]++;
            else sorted[e] = 1;

            if (total > n) {
                if (k > 0) {
                    // 가장 큰 공격 값
                    int max = sorted.Keys[sorted.Count - 1];
                    total -= max;

                    // 값 개수 감소
                    sorted[max]--;
                    if (sorted[max] == 0) sorted.Remove(max);

                    k--;
                } else {
                    return i;
                }
            }
        }

        return enemy.Length;
    }
}

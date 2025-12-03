using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] ingredient) {
        Stack<int> stack = new Stack<int>();
        int count = 0;

        foreach (int item in ingredient) {
            stack.Push(item);
            
            if (stack.Count >= 4) {
                int[] top4 = new int[4];
                int idx = 3;
                foreach (int val in stack) {
                    top4[idx--] = val;
                    if (idx < 0) break;
                }

                if (top4[0] == 1 && top4[1] == 2 && top4[2] == 3 && top4[3] == 1) {
                    for (int i = 0; i < 4; i++) stack.Pop();
                    count++;
                }
            }
        }

        return count;
    }
}
using System;

public class Solution {
    public int solution(int[] ingredient) {
        int[] stack = new int[ingredient.Length];
        int ptr = 0; // 스택 포인터
        int count = 0;

        foreach (int item in ingredient) {
            stack[ptr++] = item;

            if (ptr >= 4 &&
                stack[ptr - 4] == 1 &&
                stack[ptr - 3] == 2 &&
                stack[ptr - 2] == 3 &&
                stack[ptr - 1] == 1) 
            {
                ptr -= 4;
                count++;
            }
        }

        return count;
    }
}

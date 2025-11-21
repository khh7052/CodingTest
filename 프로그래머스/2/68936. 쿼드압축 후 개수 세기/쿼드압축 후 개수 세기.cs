public class Solution {
    int zero = 0;
    int one = 0;

    public int[] solution(int[,] arr) {
        Count(arr, 0, 0, arr.GetLength(0));
        return new int[]{ zero, one };
    }

    void Count(int[,] arr, int x, int y, int size) {
        if (IsUniform(arr, x, y, size)) {
            if (arr[y,x] == 0) zero++;
            else one++;
        } 
        else {
            int half = size / 2;
            Count(arr, x, y, half);
            Count(arr, x + half, y, half);
            Count(arr, x, y + half, half);
            Count(arr, x + half, y + half, half);
        }
    }

    bool IsUniform(int[,] arr, int x, int y, int size) {
        int standard = arr[y, x];  // 기존 value 대신 standard 사용
        for (int i = y; i < y + size; i++)
            for (int j = x; j < x + size; j++)
                if (arr[i,j] != standard) return false;
        return true;
    }
}

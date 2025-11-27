using System;

public class Solution {
    public int solution(int[,] board) {
        int n = board.GetLength(0);
        bool[,] danger = new bool[n, n];

        int[] dx = { -1, 0, 1, -1, 0, 1, -1, 0, 1 };
        int[] dy = { -1, -1, -1, 0, 0, 0, 1, 1, 1 };

        // 1. 지뢰 위치를 기록하고 주변 8칸도 위험 표시
        for (int y = 0; y < n; y++) {
            for (int x = 0; x < n; x++) {
                if (board[y, x] == 1) {
                    for (int k = 0; k < 9; k++) {
                        int nx = x + dx[k];
                        int ny = y + dy[k];

                        if (nx < 0 || ny < 0 || nx >= n || ny >= n) continue;

                        danger[ny, nx] = true;
                    }
                }
            }
        }

        // 2. 위험지역이 아닌 칸 개수 세기
        int safeCount = 0;
        for (int y = 0; y < n; y++) {
            for (int x = 0; x < n; x++) {
                if (!danger[y, x])
                    safeCount++;
            }
        }

        return safeCount;
    }
}
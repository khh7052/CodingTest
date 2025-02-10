using System;

public class Solution {
    public int solution(int[,] sizes) {
        int width = 0;
        int height = 0;
        
        for(int i = 0; i < sizes.GetLength(0); i++){
            int x = sizes[i, 0];
            int y = sizes[i, 1];
            int temp = x;
            // 전부 가로 길이가 세로보다 크도록 변경
            if(x < y){
                x = y;
                y = temp;
            }
            width = Math.Max(width, x);
            height = Math.Max(height, y);
        }
        
        return width * height;
    }
}
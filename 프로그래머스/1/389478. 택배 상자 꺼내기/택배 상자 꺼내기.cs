using System;

public class Solution {
    public int solution(int n, int w, int num) {
        int answer = 0;
        int current = 1;
        int[,] area = new int[n,n];
        bool isLeft = false;
        int x = 0;
        int y = 0;
        
        
        while(n > 0){
            if(current++ == num){
                area[y, x] = 2;
                answer++;
            }
            else{
                if(y > 0){
                    area[y, x] = area[y-1, x];
                    if(area[y, x] == 2)
                        answer++;
                }
                else
                    area[y,x] = 1;
            }
            
            if(isLeft){
                x--;
                if(x < 0) {
                    x++;
                    y++;
                    isLeft = false;
                }
            }
            else{
                x++;
                if(x >= w) {
                    x--;
                    y++;
                    isLeft = true;
                }
            }
            
            n--;
        }
        
        return answer;
    }
}
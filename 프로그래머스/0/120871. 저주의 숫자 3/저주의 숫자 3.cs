using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        for(int i = 0; i < n; i++){
            answer++;
            
            // 3의 배수일 때, 끝자리가 3일 때, 30의 범위일때
            while(answer % 3 == 0 || answer.ToString().Contains('3'))
                answer++;
        }
        
        return answer;
    }
}
using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        while(n > 0){
            int cur = n % 10;
            n /= 10;
            answer += cur;
        }
        
        return answer;
    }
}
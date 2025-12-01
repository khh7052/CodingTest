using System;

public class Solution {
    public int solution(int give, int take, int empty) {
        int answer = 0;
        
        while(empty >= give){
            empty -= give;
            empty += take;
            answer += take;
        }
        
        return answer;
    }
}
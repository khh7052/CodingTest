using System;

public class Solution {
    public int solution(int[] d, int budget) {
        int answer = 0;
        Array.Sort(d);
        
        foreach(int cost in d){
            if(budget >= cost){
                budget -= cost;
                answer++;
            }
            else return answer;
        }
        
        return answer;
    }
}
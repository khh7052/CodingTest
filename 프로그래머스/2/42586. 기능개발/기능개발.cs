using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] progresses, int[] speeds) {
        List<int> answer = new List<int>();
        int max = -1;
        int count = 0;
        int start = 0;
        for(int i = 0; i < 100; i++){
            
            for(int j = 0; j < progresses.Length; j++){
                if(speeds[j] <= 0) continue;
                
                progresses[j] += speeds[j];
                
                if(start == j && progresses[j] >= 100){
                    count++;
                    start++;
                    speeds[j] = 0;
                }
            }
            
            if(count > 0){
                answer.Add(count);
                count = 0;
            }
        }
        
        return answer.ToArray();
    }
}
using System;

public class Solution {
    public int[] solution(int[,] score) {
        int length = score.GetLength(0);
        int[] answer = new int[length];
        
        for(int i = 0; i < length; i++){
            answer[i] = length;
            int myScore = score[i,0] + score[i,1];
            
            for(int j = 0; j < length; j++){
                if(j == i) continue;
                int otherScore = score[j,0] + score[j,1];
                
                if(myScore >= otherScore)
                    answer[i]--;
            }
        }
        
        return answer;
    }
}
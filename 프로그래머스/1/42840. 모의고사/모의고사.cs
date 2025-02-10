using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] answers) {
        int[] answer = new int[] {};
        List<int> answerList = new List<int>();
        int[] one = {1, 2, 3, 4, 5};
        int[] two = {2, 1, 2, 3, 2, 4, 2, 5};
        int[] three = {3, 3, 1, 1, 2, 2, 4, 4, 5, 5};
        int[] counts = new int[3];
        
        int oneIdx = 0, twoIdx = 0, threeIdx = 0;
        
        for(int i = 0; i < answers.Length; i++){
            int ans = answers[i];
            
            if(ans == one[oneIdx]) counts[0]++;
            if(ans == two[twoIdx]) counts[1]++;
            if(ans == three[threeIdx]) counts[2]++;
            
            oneIdx = ++oneIdx < one.Length? oneIdx: 0;
            twoIdx = ++twoIdx < two.Length? twoIdx: 0;
            threeIdx = ++threeIdx < three.Length? threeIdx: 0;
        }
        
        int maxCount = counts.Max();
        int answerCount = 0;
        
        for(int i = 0; i < counts.Length; i++){
            if(maxCount == counts[i])
                answerList.Add(i+1);
        }
        
        answer = answerList.ToArray();
        
        return answer;
    }
}
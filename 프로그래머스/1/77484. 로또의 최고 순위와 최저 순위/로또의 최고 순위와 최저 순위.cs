using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        HashSet<int> winSet = new HashSet<int>(win_nums);
        int zeroCount = 0;
        int correctCount = 0;

        foreach(int lotto in lottos){
            if(lotto == 0) zeroCount++;
            else if(winSet.Contains(lotto)) correctCount++;
        }

        int maxRank = Math.Min(7 - (correctCount + zeroCount), 6);
        int minRank = Math.Min(7 - correctCount, 6);

        return new int[]{ maxRank, minRank };
    }
}
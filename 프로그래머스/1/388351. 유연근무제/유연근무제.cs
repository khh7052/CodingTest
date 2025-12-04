using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] schedules, int[,] timelogs, int startday) {
        int answer = schedules.Length;
        
        for(int i = 0; i < timelogs.GetLength(0); i++){
            int limit = GetTimeToMinute(schedules[i]) + 10;
            int currentDay = startday;
            
            for(int j = 0; j < timelogs.GetLength(1); j++){
                if(currentDay <= 5){
                    int currentMinute = GetTimeToMinute(timelogs[i, j]);
                
                    if(currentMinute > limit){
                        answer--;
                        break;
                    }
                }
                
                currentDay = NextDay(currentDay);
            }
        }
        
        return answer;
    }
    
    public int NextDay(int day)
        => day == 7 ? 1 : day + 1;
    
    public int GetTimeToMinute(int time)
        => (time % 100) + ((time / 100) * 60);
}
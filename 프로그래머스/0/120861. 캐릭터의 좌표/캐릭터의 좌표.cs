using System;

public class Solution {
    public int[] solution(string[] keyinput, int[] board) {
        int[] answer = { 0, 0 };
        int width = board[0] / 2;
        int height = board[1] / 2;
        
        foreach(string input in keyinput){
            if(input == "left")  answer[0] = Math.Max(answer[0] - 1, -width);
            if(input == "right") answer[0] = Math.Min(answer[0] + 1, width);
            if(input == "up")    answer[1] = Math.Min(answer[1] + 1, height);
            if(input == "down")  answer[1] = Math.Max(answer[1] - 1, -height);
        }
        
        return answer;
    }
}
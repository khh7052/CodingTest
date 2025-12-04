using System;

public class Solution {
    public string solution(string video_len, string pos, string op_start, string op_end, string[] commands) {
        int lenSec = TimeToSecond(video_len);
        int mySec = TimeToSecond(pos);
        int startSec = TimeToSecond(op_start);
        int endSec = TimeToSecond(op_end);
        
        mySec = Skip(mySec, startSec, endSec);
        foreach(string command in commands){
            switch(command){
                case "next":
                    mySec = Next(mySec, lenSec);
                    break;
                case "prev":
                    mySec = Prev(mySec);
                    break;
            }
            
            mySec = Skip(mySec, startSec, endSec);
        }
        
        return SecondToTime(mySec);
    }
    
    public int Next(int time, int len)
        =>  Math.Min(time + 10, len);
    
    public int Prev(int time)
        =>  Math.Max(time - 10, 0);
    
    public int Skip(int time, int start, int end)
        => (start <= time && time <= end) ? end : time;
    
    public int TimeToSecond(string time){
        string[] split = time.Split(':');
        return int.Parse(split[1]) + (int.Parse(split[0]) * 60);
    }
    
    public string SecondToTime(int second){
        int minute = second / 60;
        int sec = second % 60;
        
        return $"{minute:00}:{sec:00}";
    }
}
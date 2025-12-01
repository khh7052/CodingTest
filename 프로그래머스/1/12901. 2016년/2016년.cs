using System;

public class Solution {
    
    enum DateType
    {
        SUN,
        MON,
        TUE,
        WED,
        THU,
        FRI,
        SAT,
    };
    
    public string solution(int a, int b) {
        DateTime dt = new DateTime(2016, a, b);
        int week = (int)dt.DayOfWeek;  
        return ((DateType)week).ToString();
    }
}

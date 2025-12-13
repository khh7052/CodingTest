using System;

public class Solution {
    public string solution(string s) {
        string[] split = s.Split();
        int max = int.MinValue;
        int min = int.MaxValue;
        
        foreach(string str in split){
            int num = int.Parse(str);
            max = Math.Max(num, max);
            min = Math.Min(num, min);
        }
        
        return $"{min} {max}";
    }
}
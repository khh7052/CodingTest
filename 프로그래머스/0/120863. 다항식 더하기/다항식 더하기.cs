using System;

public class Solution {
    public string solution(string polynomial) {
        string answer = "";
        int x = 0;
        int num = 0;
        
        string[] split = polynomial.Split(" + ");
        foreach(string s in split){
            if(s[s.Length-1] == 'x'){
                if(s.Length == 1) x++;
                else x += int.Parse(s.Substring(0, s.Length-1));
            }
            else
                num += int.Parse(s);
        }
        
        if(x > 0) answer = x == 1 ? "x" : x + "x";
        if(num > 0) answer += answer != "" ? " + " + num : num.ToString();
        
        return answer;
    }
}
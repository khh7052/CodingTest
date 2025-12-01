using System;
using System.Collections.Generic;
using System.Text;

public class Solution {
    public int solution(string s) {
        Dictionary<string, int> dict = new Dictionary<string, int>()
        {
            {"zero", 0},
            {"one", 1},
            {"two", 2},
            {"three", 3},
            {"four", 4},
            {"five", 5},
            {"six", 6},
            {"seven", 7},
            {"eight", 8},
            {"nine", 9},
        };
        
        int answer = 0;
        StringBuilder sb = new StringBuilder();
        
        for(int i = 0; i < s.Length; i++){
            if(char.IsDigit(s[i])){
                answer *= 10;
                answer += s[i] - '0';
                continue;
            }
            sb.Append(s[i]);
            
            if(dict.ContainsKey(sb.ToString())){
                answer *= 10;
                answer += dict[sb.ToString()];
                sb.Clear();
            }
        }
        
        return answer;
    }
}
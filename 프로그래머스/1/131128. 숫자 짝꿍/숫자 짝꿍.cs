using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution {
    public string solution(string X, string Y) {
        StringBuilder sb = new StringBuilder();
        SortedDictionary<char, int> dict = new SortedDictionary<char, int>();
        SortedDictionary<char, int> overlap = new SortedDictionary<char, int>();
        
        foreach(char c in X){
            if(dict.ContainsKey(c))
                dict[c]++;
            else
                dict.Add(c, 1);
        }
        
        foreach(char c in Y){
            if(dict.ContainsKey(c) && dict[c] > 0){
                dict[c]--;
                
                if(overlap.ContainsKey(c))
                    overlap[c]++;
                else
                    overlap.Add(c, 1);
            }
        }
        
        foreach(var v in overlap.Reverse())
            sb.Append(v.Key, v.Value);
        
        string str = sb.ToString();
        
        if(str.Length == 0) return "-1";
        if (str[0] == '0') return "0";
        
        return str;
    }
}
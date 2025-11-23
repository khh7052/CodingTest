using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string[] spell, string[] dic) {
        HashSet<string> spellSet = new HashSet<string>();
        
        foreach(string s in spell)
            spellSet.Add(s);
        
        foreach(string str in dic){
            if(spellSet.Count != str.Length) continue;
            HashSet<string> temp = new HashSet<string>(spellSet);
            
            foreach(char c in str){
                if(!temp.Contains(c.ToString())) break;
                temp.Remove(c.ToString());
            }
            
            if(temp.Count == 0) return 1;
        }
        
        return 2;
    }
}
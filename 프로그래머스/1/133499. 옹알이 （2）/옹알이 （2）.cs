using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string[] babbling) {
        HashSet<string> hashSet = new HashSet<string>(){
            "aya",
            "ye",
            "woo",
            "ma"
        };
        
        int answer = 0;
        
        foreach(string str in babbling){
            bool canBabbling = true;
            string currentBabbling = "";
            string lastBabbling = "";
            
            foreach(char c in str){
                currentBabbling += c;
                
                if(hashSet.Contains(currentBabbling)){
                    if(currentBabbling == lastBabbling){
                        canBabbling = false;
                        break;
                    }
                    lastBabbling = currentBabbling;
                    currentBabbling = "";
                }
            }
            
            if(currentBabbling.Length > 0) canBabbling = false;
            if(canBabbling) answer++;
        }
        
        return answer;
    }
}
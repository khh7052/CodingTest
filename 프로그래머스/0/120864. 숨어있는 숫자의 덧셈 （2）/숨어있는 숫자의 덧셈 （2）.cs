using System;

public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        int start = 0;
        int length = 0;
        
        for(int i = 0; i < my_string.Length; i++){
            if(char.IsDigit(my_string[i])){
                if(length == 0) start = i;
                length++;
            }
            else{
                if(length > 0){
                    answer += int.Parse(my_string.Substring(start, length));
                    length = 0;
                }
            }
        }
        
                if(length > 0){
                    answer += int.Parse(my_string.Substring(start, length));
                    length = 0;
                }
        
        return answer;
    }
}
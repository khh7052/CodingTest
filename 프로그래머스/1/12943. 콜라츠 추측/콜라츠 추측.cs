using System;

public class Solution {
    public int solution(int num) {
        int answer = 0;
        while(num != 1){
            Console.WriteLine(num);
            if(num % 2 == 0) num /= 2;
            else num = num * 3 + 1;
            if(++answer > 500) return -1;
            if(num <= 0) return -1;
        }
        
        return answer;
    }
}
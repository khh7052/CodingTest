using System;

public class Solution {
    public int solution(int number, int limit, int power) {
        int answer = 0;
        
        for(int i = 1; i <= number; i++){
            int divisors = GetDivisors(i);
            answer += divisors > limit ? power : divisors;
        }
        
        return answer;
    }
    
    private int GetDivisors(int num){
        int count = 0;
        int sqrt = (int)Math.Sqrt(num);

        for(int i = 1; i <= sqrt; i++){
            if(num % i == 0)
                count += 2;
        }
        
        if(sqrt * sqrt == num) count--;

        return count;
    }
}

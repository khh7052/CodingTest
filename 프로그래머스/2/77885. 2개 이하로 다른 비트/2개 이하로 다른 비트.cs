using System;

public class Solution {
    public long[] solution(long[] numbers) {
        
        for(int i = 0; i < numbers.Length; i++){
            if(numbers[i] % 2 == 0)
                numbers[i] += 1;
            else{
                long bit = 1;
                
                while ((numbers[i] & bit) != 0)
                    bit <<= 1;
                
                numbers[i] ^= (bit | (bit >> 1));
            }
        }
        
        return numbers;
    }
}
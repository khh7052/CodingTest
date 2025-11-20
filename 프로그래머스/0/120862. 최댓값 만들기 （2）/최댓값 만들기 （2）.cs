using System;

public class Solution {
    public int solution(int[] numbers) {
        int max1 = -int.MaxValue;
        int max2 = -int.MaxValue;
        
        int min1 = int.MaxValue;
        int min2 = int.MaxValue;
        
        foreach(int number in numbers){
            if(number > max1){
                max2 = max1;
                max1 = number;
            }
            else if(number > max2)
                max2 = number;
            
            if(number < min1){
                min2 = min1;
                min1 = number;
            }
            else if(number < min2)
                min2 = number;
        }
        
        
        return Math.Max(max1 * max2, min1 * min2);
    }
}
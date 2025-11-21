using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] numbers, int target) {
        int count = 0;
        Queue<(int index, int sum)> queue = new Queue<(int, int)>();
        
        queue.Enqueue((0, 0));
        
        while(queue.Count > 0){
            var (idx, sum) = queue.Dequeue();
            
            if(idx == numbers.Length){
                if(sum == target) count++;
                continue;
            }
            
            int num = numbers[idx++];
            
            queue.Enqueue((idx, sum + num));
            queue.Enqueue((idx, sum - num));
        }
        
        return count;
    }
}

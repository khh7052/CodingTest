using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] number) {
        int answer = 0;
        Queue<(int index, bool[] visited, int sum, int count)> queue = new Queue<(int, bool[], int sum, int count)>();
        
        for(int i = 0; i < number.Length; i++)
            queue.Enqueue((i, new bool[number.Length], 0, 0));
        
        while(queue.Count > 0){
            var q = queue.Dequeue();
            int idx = q.index;
            q.visited[idx] = true;
            q.sum += number[idx];
            q.count++;
            
            if(q.count == 3){
                if(q.sum == 0)
                    answer++;
            }
            else{
                for(int i = 0; i < q.visited.Length; i++){
                    if(q.visited[i]) continue;
                    queue.Enqueue((i, q.visited, q.sum, q.count));
                }
            }
        }
        
        return answer / 3;
    }
}
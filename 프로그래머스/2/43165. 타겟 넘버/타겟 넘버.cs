using System;
using System.Collections.Generic;

public class Solution {
    
    public int DFS(int num, int target, int idx, int[] numbers){
        if(++idx == numbers.Length){
            if(num == target) return 1;
            else return 0;
        }
        //Console.WriteLine($"num : {num}  idx : {idx}");
        return DFS(num + numbers[idx], target, idx, numbers) + DFS(num - numbers[idx], target, idx, numbers);
    }
    
    public int solution(int[] numbers, int target) {
        int answer = 0;
        answer = DFS(0, target, -1, numbers);
        
        return answer;
    }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    /*
    int answer = 0;
    int[] numbers;
    int target;
    
    void DFS(int depth, int sum){
        depth++; // depth 증가
        
        // 끝까지 도달하면 sum이 target과 같은지 비교하고 종료
        if(depth == numbers.Length){
            if(sum == target) answer++;
            return;
        }
        DFS(depth, sum + numbers[depth]); // 양수 부분
        DFS(depth, sum + (numbers[depth]*-1)); // 음수 부분
    }
    
    public int solution(int[] numbers, int target) {
        this.numbers = numbers;
        this.target = target;
        
        DFS(0, numbers[0]); // 양수 부분
        DFS(0, numbers[0]*-1); // 음수 부분
        
        return answer;
    }
    */
}
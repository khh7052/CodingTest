using System;

public class Solution {
    public int solution(int n, int[,] computers) {
        int answer = 0;
        bool[] visited = new bool[n];
        
        for(int i = 0; i < n; i++)
            answer += DFS(computers, visited, i);
        
        return answer;
    }
    
    public int DFS(int[,] computers, bool[] visited, int idx){
        if(visited[idx]) return 0;
        visited[idx] = true;
        
        for(int i = 0; i < computers.GetLength(1); i++){
            if(computers[idx, i] == 0) continue;
            DFS(computers, visited, i);
        }
        
        return 1;
    }
    
}
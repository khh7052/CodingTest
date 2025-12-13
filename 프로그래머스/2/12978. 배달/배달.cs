using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    struct Edge{
        public int to;
        public int cost;
        
        public Edge(int to, int cost){
            this.to = to;
            this.cost = cost;
        }
    }
    
    
    public int solution(int N, int[,] road, int K)
    {
        List<List<Edge>> graph = new List<List<Edge>>();
        int[] cost = new int[N+1]; // 각 지점 최소비용
        bool[] visited = new bool[N+1]; // 각 지점 방문여부
        int start = 1; // 시작 지점
        
        Array.Fill(cost, int.MaxValue);
        
        for(int i = 0; i <= N; i++)
            graph.Add(new List<Edge>());
        
        for(int i = 0; i < road.GetLength(0); i++){
            int a = road[i,0];
            int b = road[i,1];
            int c = road[i,2];
            
            graph[a].Add(new Edge(b, c));
            graph[b].Add(new Edge(a, c));
        }
        
        cost[start] = 0;
        
        for(int i = 1; i <= N; i++){
            int current = GetSmallIndex(visited, cost, N);
            visited[current] = true;
            
            foreach(Edge edge in graph[current]){
                cost[edge.to] = Math.Min(cost[edge.to], cost[current] + edge.cost);
                Console.WriteLine($"cur {current} to {edge.to} cost {cost[edge.to]}");
            }
        }

        return cost.Count(x => x <= K);
    }
    
    // 방문하지 않은 노드중에서 가장 작은 노드 반환
    int GetSmallIndex(bool[] visited, int[] cost, int N){
        int minValue = int.MaxValue;
        int minIdx = -1;
        
        for(int i = 1; i <= N; i++){
            if(visited[i]) continue;
            
            if(minValue > cost[i]){
                minValue = cost[i];
                minIdx = i;
            }
        }
        
        return minIdx;
    }
}
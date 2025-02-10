using System;
using System.Collections.Generic;

class Solution {
    public int solution(int[,] maps) {
        
        int height = maps.GetLength(0);
        int width = maps.GetLength(1);
        bool[,] visited = new bool[height, width];
        Queue<(int x, int y, int depth)> posQueue = new Queue<(int, int, int)>();
        posQueue.Enqueue((0, 0, 1));
        
        int[] dirX = {0, 0, 1, -1};
        int[] dirY = {-1, 1, 0, 0};
        
        while(posQueue.Count > 0){
            var pos = posQueue.Dequeue();
            if(visited[pos.y, pos.x]) continue;
            
            if(pos.x == width-1 && pos.y == height-1) return pos.depth;
            visited[pos.y, pos.x] = true;
            
            for(int i = 0; i < 4; i++){
                int newX = pos.x + dirX[i];
                int newY = pos.y + dirY[i];
                
                if(newX < 0 || width <= newX) continue;
                if(newY < 0 || height <= newY) continue;
                if(maps[newY, newX] == 0) continue;
                if(visited[newY, newX]) continue;
                
                posQueue.Enqueue((newX, newY, pos.depth+1));
            }
        }
        
        
        return -1;
    }
}



/*
class Solution {
    int n = 0;
    int m = 0;
    
    int[] dx = {-1, 1, 0, 0};
    int[] dy = {0, 0, -1, 1};
    
    Queue<(int, int)> q = new Queue<(int, int)>();
    
    public void BFS(int i, int j, int[,] arr)
    {
        //큐에 지금 값 넣기
        q.Enqueue((i,j));
        
        //큐가 없어질 때 까지 반복
        while(q.Count > 0)
        {
            (int a, int b) = q.Dequeue();
            
            //상하좌우
            for(int k = 0; k < 4; k++)
            {
                int nx = a + dx[k]; // x방향 이동
                int ny = b + dy[k]; // y방향 이동
                
                // 범위 넘어가면 넘어감
                if(nx < 0 || nx >=n || ny < 0 || ny >= m) continue;
                // 벽이면 넘어감
                if(arr[nx,ny] == 0) continue;
                // 간적없는 길이면 카운트 더하고 현재 위치 큐에 저장
                
                if(nx == n-1 && ny == m-1){
                    arr[nx,ny] = arr[a,b] + 1;
                    return;
                }
                
                if(arr[nx,ny]==1)
                {
                    arr[nx,ny] = arr[a,b] + 1; // (지나간 길은 이전값 + 1)
                    q.Enqueue((nx,ny));
                }
            }
        }
    }
    
    public int solution(int[,] maps) 
    {
        //maps의 길이저장
        n = maps.GetLength(0);
        m = maps.GetLength(1);
        
        //dfs진행
        BFS(0, 0, maps);
        
        // 상대팀 진영에 도달하지 못하면 -1을 반환 (1이면 도착한적 없음)
        if(maps[n-1,m-1] == 1) return -1;
        else return (maps[n - 1, m - 1]); 
    }
    
}
*/
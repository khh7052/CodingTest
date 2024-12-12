#include <string>
#include <string.h>
#include <vector>
#include <queue>
using namespace std;

int solution(vector<string> board)
{
    int dx[4] = {-1,1,0,0};
    int dy[4] = {0,0,-1,1};
    int height = board.size();
    int width = board[0].size();
    int visited[100][100];
    memset(visited, -1, sizeof(visited));
    queue<pair<int,int>> q;
    
    for(int y=0; y < height; y++)
        for(int x=0; x < width;x++)
            if(board[y][x] == 'R') q.push({y,x});
    
    visited[q.front().first][q.front().second] = 0;
    
    while(!q.empty())
    {
        pair<int,int> currentPos = q.front();
        q.pop();
        
        for(int dir = 0; dir < 4; dir++)
        {
            int y = currentPos.first;
            int x = currentPos.second;
            
            while (true)
            {
                if (x < 0 || y < 0 || x >= width || y >= height) break; // 벽 판정
                if (board[y][x] == 'D') break; // 장애물 판정
                
                x += dx[dir];
                y += dy[dir];
            }
            
            x -= dx[dir];
            y -= dy[dir];
            
            if (board[y][x] == 'G') return (visited[currentPos.first][currentPos.second] + 1);
            
            if (visited[y][x]>=0) continue;
            visited[y][x] = visited[currentPos.first][currentPos.second] + 1;
            q.push({y, x});
        }
    }
    
    return -1;
}
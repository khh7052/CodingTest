#include <string>
#include <string.h>
#include <vector>
#include <queue>

using namespace std;

int solution(vector<string> maps) {
    int answer = 0;
    int dx[4] = {-1, 1, 0, 0};
    int dy[4] = {0, 0, -1, 1};
    int visited[110][110];
    queue<pair<int, int>> q;
    
    int height = maps.size();
    int width = maps[0].length();
    
    for(int y = 0; y < height; y++){
        for(int x = 0; x < width; x++){
            if(maps[y][x] == 'S'){
                q.push({x, y});
                break;
            }
        }
    }
    
    bool onLever = false;
    while(!q.empty()){
        auto pos = q.front();
        int x = pos.first;
        int y = pos.second;
        
        // printf("%i %i %i %c\n", x, y, visited[y][x], maps[y][x]);
        
        if(maps[y][x] == 'L'){
            onLever = true;
            answer = visited[y][x];
            memset(visited, 0, sizeof(visited));
            q = queue<pair<int, int>>();
            q.push({x, y});
            break;
        }
        
        for(int i = 0; i < 4; i++){
            int nextX = x+dx[i];
            int nextY = y+dy[i];
            if(nextY < 0 || nextY >= height) continue;
            if(nextX < 0 || nextX >= width) continue;
            if(maps[nextY][nextX] == 'X') continue;
            if(visited[nextY][nextX] > 0) continue;
            visited[nextY][nextX] = visited[y][x] + 1;
            q.push({nextX, nextY});
        }
        
        q.pop();
    }
    
    if(!onLever) return -1;
    
    while(!q.empty()){
        auto pair = q.front();
        int x = pair.first;
        int y = pair.second;
        
        // printf("%i %i %i %c\n", x, y, visited[y][x], maps[y][x]);
        
        if(maps[y][x] == 'E') return visited[y][x] + answer;
        
        for(int i = 0; i < 4; i++){
            int nextX = x+dx[i];
            int nextY = y+dy[i];
            if(nextY < 0 || nextY >= height) continue;
            if(nextX < 0 || nextX >= width) continue;
            if(maps[nextY][nextX] == 'X') continue;
            if(visited[nextY][nextX] > 0) continue;
            visited[nextY][nextX] = visited[y][x] + 1;
            q.push({nextX, nextY});
        }
        
        q.pop();
    }
    
    return -1;
}
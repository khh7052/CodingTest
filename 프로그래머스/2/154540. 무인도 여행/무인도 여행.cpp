#include <string>
#include <vector>
#include <queue>
#include <algorithm>

using namespace std;

vector<int> solution(vector<string> maps) {
    vector<int> answer;
    int height = maps.size();
    int width = maps[0].length();
    
    vector<vector<bool>> visited(height, vector<bool> (width, false));
    queue<pair<int, int>> q;
    
    int dx[4] = {-1, 1, 0, 0};
    int dy[4] = {0, 0, -1, 1};
    
    for(int y = 0; y < height; y++){
        for(int x = 0; x < width; x++){
            if(visited[y][x]) continue;
            if(maps[y][x] == 'X') continue;
            
            q.push({x, y});
            int sum = 0;
            
            while(!q.empty()){
                auto& pos = q.front();
                q.pop();
                int x = pos.first;
                int y = pos.second;
                if(visited[y][x]) continue;
                if(maps[y][x] == 'X') continue;
                sum += maps[y][x] - '0';
                visited[y][x] = true;
                
                
                for(int i = 0; i < 4; i++){
                    int nextX = dx[i] + x;
                    int nextY = dy[i] + y;
                    if(0 > nextX || nextX >= width) continue;
                    if(0 > nextY || nextY >= height) continue;
                    if(visited[nextY][nextX]) continue;
                    if(maps[nextY][nextX] == 'X') continue;
                    q.push({nextX, nextY});
                }
            }
            
            answer.push_back(sum);
        }
    }
    
    if(answer.size() == 0)
        answer.push_back(-1);
    else
        sort(answer.begin(), answer.end());
    return answer;
}
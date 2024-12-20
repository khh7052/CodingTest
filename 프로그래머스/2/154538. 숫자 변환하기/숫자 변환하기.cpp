#include <string>
#include <vector>
#include <algorithm>
#include <queue>

using namespace std;

int solution(int x, int y, int n) {
    queue<int> q;
    vector<int> visited(y+1, 0);
    
    q.push(x);
    while(!q.empty()){
        int num = q.front(); q.pop();
        
        if(num == y) return visited[num];
        
        int dx[3] = {num + n, num * 2, num * 3};
        
        for(int i = 0; i < 3; i++){
            if(dx[i] > y || visited[dx[i]] > 0) continue;
            visited[dx[i]] = visited[num] + 1;
            q.push(dx[i]);
        }
        
    }
    
    return -1;
}
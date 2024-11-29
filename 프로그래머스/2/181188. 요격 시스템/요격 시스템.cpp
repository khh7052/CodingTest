#include <string>
#include <vector>
#include <queue>
#include <iostream>
#include <functional>

using namespace std;

int solution(vector<vector<int>> targets) {
    
    struct cmp {
        bool operator()(vector<int> a, vector<int> b) {
            return a[1] > b[1];
        }
    };
    
    priority_queue<vector<int>, vector<vector<int>>, cmp> q;
    
    for(auto& target : targets){
        q.push(target);
    }
    
    int answer = 0;
    
    while (!q.empty()) {
        int end = q.top()[1];
        
        cout << q.top()[0] << " " << q.top()[1] << '\n';
        q.pop();
        answer++;
        
        while (!q.empty()){
            int nextStart = q.top()[0];
            
            if(end > nextStart){
                q.pop();
            }
            else{
                break;
            }
        }
    }
    
    
    return answer;
}
#include <string>
#include <vector>
#include <algorithm>
#include <stack>

using namespace std;

bool compare(vector<string> a, vector<string> b){
    return a[1] < b[1];
}

vector<string> solution(vector<vector<string>> plans) {
    vector<string> answer;
    stack<pair<string, int>> pausePlans;
    
    sort(plans.begin(), plans.end(), compare);
    
    for(int i = 0; i < plans.size()-1; i++){
        vector<string>& currentPlan = plans[i];
        vector<string>& nextPlan = plans[i+1];
        
        string name = currentPlan[0];
        int currentStartTime = stoi(currentPlan[1].substr(0, 2)) * 60 + stoi(currentPlan[1].substr(3, 2));
        int nextStartTime = stoi(nextPlan[1].substr(0, 2)) * 60 + stoi(nextPlan[1].substr(3, 2));
        
        int currentPlayTime = stoi(currentPlan[2]);
        int startTimeGap = nextStartTime - currentStartTime;
        int minTime = min(currentPlayTime, startTimeGap);
        currentPlayTime -= minTime;
        startTimeGap -= minTime;
        
        // 과제를 다 못했을 때
        if(currentPlayTime > 0){
            pausePlans.push(make_pair(name, currentPlayTime));
        }
        // 과제를 다 했을 때
        else{
            answer.push_back(name);
            
            // 시간이 남았을 때 남은 과제 진행
            while(!pausePlans.empty() && startTimeGap > 0){
                pair<string, int>& plan = pausePlans.top();
                int& time = plan.second;
                
                minTime = min(time, startTimeGap);
                time -= minTime;
                startTimeGap -= minTime;
                
                if(time <= 0){
                    answer.push_back(plan.first);
                    pausePlans.pop();
                }
            }
        }
    }
    
    answer.push_back(plans.back()[0]);
    
    while(!pausePlans.empty()){
        answer.push_back(pausePlans.top().first);
        pausePlans.pop();
    }
    
    return answer;
}
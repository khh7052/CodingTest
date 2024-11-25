#include <string>
#include <vector>
#include <unordered_map>

using namespace std;

vector<int> solution(vector<string> name, vector<int> yearning, vector<vector<string>> photo) {
    vector<int> answer;
    unordered_map<string, int> score_map;
    
    for(int i = 0; i < name.size(); i++)
        score_map[name[i]] = yearning[i];
    
    for(auto v : photo){
        int sum = 0;
        for(auto person : v)
            sum += score_map[person];
        
        answer.push_back(sum);
    }
    
    return answer;
}
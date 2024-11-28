#include <string>
#include <vector>
#include <unordered_map>
#include <algorithm>

using namespace std;

vector<int> solution(vector<string> keymap, vector<string> targets) {
    vector<int> answer;
    unordered_map<char, int> keyCountMap;
    
    for(auto& str : keymap){
        for(int i = 0; i < str.length(); i++){
            char c = str[i];
            int count = (i+1);
            
            if(keyCountMap.find(c) == keyCountMap.end()){
                keyCountMap[c] = count;
            }
            else{
                keyCountMap[c] = min(count, keyCountMap[c]);
            }
        }
    }
    
    for(auto& target : targets){
        int count = 0;
        
        for(auto& c : target){
            if(keyCountMap.find(c) == keyCountMap.end()){
                count = -1;
                break;
            }
            
            count += keyCountMap[c];
        }
        
        answer.push_back(count);
    }
    
    return answer;
}
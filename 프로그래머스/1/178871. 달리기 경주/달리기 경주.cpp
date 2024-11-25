#include <string>
#include <vector>
#include <map>
#include <iostream>
#include <algorithm>

using namespace std;

vector<string> solution(vector<string> players, vector<string> callings) {
    map<string, int> playerIndexMap;
    
    for(int i = 0; i < players.size(); i++){
        playerIndexMap[players[i]] = i;
    }
    
    for(auto calling:callings){
        int callingIdx = playerIndexMap[calling];
        playerIndexMap[players[callingIdx]]--;
        playerIndexMap[players[callingIdx-1]]++;
        
        swap(players[callingIdx], players[callingIdx-1]);
    }
    
    return players;
}
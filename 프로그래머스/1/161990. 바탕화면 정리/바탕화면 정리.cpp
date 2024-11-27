#include <string>
#include <vector>
#include <algorithm>

using namespace std;

vector<int> solution(vector<string> wallpaper) {
    vector<int> answer;
    
    int x, y = 0;
    int minX = 50, minY = 50, maxX = -1, maxY = -1;
    for(auto& paper : wallpaper){
        x = 0;
        
        for(auto& c : paper){
            if(c == '#'){
                minX = min(x, minX);
                minY = min(y, minY);
                maxX = max(x+1, maxX);
                maxY = max(y+1, maxY);
            }
            x++;
        }
        
        y++;
    }
    
    answer.push_back(minY);
    answer.push_back(minX);
    answer.push_back(maxY);
    answer.push_back(maxX);
    
    return answer;
}
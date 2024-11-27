#include <string>
#include <vector>
#include <unordered_map>
#include <sstream>
#include <algorithm>

using namespace std;

int solution(vector<string> friends, vector<string> gifts) {
    int answer = 0;
    unordered_map<string, unordered_map<string, int>> gift_map;
    unordered_map<string, int> gift_point_map;
    
    // 1. 선물을 상대보다 덜 받았으면 다음 달에 선물 +1
    // 2. 두 사람의 선물 교환이 같다면 선물 지수가 작은 사람에게 선물 +1
    // 3. 
    for(auto& f : friends){
        for(auto& fr : friends){
            if(f == fr) continue;
            
            gift_map[f][fr] = 0;
        }
        gift_point_map[f] = 0;
    }
    
    for(auto& gift : gifts){
        stringstream ss(gift);
        string giver, taker;
        ss >> giver >> taker;
        
        gift_map[giver][taker]++;
        gift_point_map[giver]++;
        gift_point_map[taker]--;
    }
    
    for(auto& gift : gift_map){
        int count = 0;
        string giver = gift.first;
        for(auto& taker_map : gift.second){
            string taker = taker_map.first;
            int giver_gift = gift_map[giver][taker];
            int taker_gift = gift_map[taker][giver];
            
            printf("Giver : %s Taker : %s Giver_gift : %i Taker_gift : %i\n", giver.c_str(), taker.c_str(), giver_gift, taker_gift);
            if(giver_gift == taker_gift){
                if(gift_point_map[giver] > gift_point_map[taker]){
                    count++;
                }
            }
            else if(giver_gift > taker_gift){
                count++;
                printf("%s %s count plus %i\n", giver.c_str(), taker.c_str(), count);
            }
        }
        printf("%s gift count %i\n", giver.c_str(), count);
        answer = max(count, answer);
    }
    
    return answer;
}
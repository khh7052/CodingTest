#include <string>
#include <vector>
#include <algorithm>

using namespace std;

#define DIAVALUE 10000
#define IRONVALUE 100
#define STONEVALUE 1

int GetMineralValue(string mineral){
    if(mineral == "diamond") return DIAVALUE;
    if(mineral == "iron") return IRONVALUE;
    if(mineral == "stone") return STONEVALUE;
    return 0;
}

int GetMineralFatigue(string pick, string mineral){
    if(pick == "iron"){
        if(mineral == "diamond") return 5;
    }
    
    if(pick == "stone"){
        if(mineral == "diamond") return 25;
        if(mineral == "iron") return 5;
    }
    
    return 1;
}

int GetValueToFatigue(string pick, int value){
    int diaCount = value / DIAVALUE;
    int ironCount = (value % DIAVALUE) / IRONVALUE;
    int stoneCount = (value % IRONVALUE) / STONEVALUE;
    
    int diaFatigue = GetMineralFatigue(pick, "diamond") * diaCount;
    int ironFatigue = GetMineralFatigue(pick, "iron") * ironCount;
    int stoneFatigue = GetMineralFatigue(pick, "stone") * stoneCount;
    
    // printf("value : %i %i %i %i \n", value, diaCount, ironCount, stoneCount);
    
    return diaFatigue + ironFatigue + stoneFatigue;
}

bool compare(int& a, int& b){
    return a > b;
}

int solution(vector<int> picks, vector<string> minerals) {
    
    // 1. minerals를 5개씩 묶는다.
    // 2. 광물 등급 기준으로 크기를 지정한다.
    // 3. 광물을 담은 vector의 길이는 곡괭이 수만큼 줄인다.
    // 4. 가장 큰 순서부터 피로도를 계산하고, 가장 높은 등급의 곡괭이를 배치한다.
    
    int answer = 0;
    vector<int> mineralValues;
    
    int mineralValue = 0;
    int pickCount = picks[0] + picks[1] + picks[2];
    
    for(int i = 0, count = 0; i < minerals.size(); i++){
        string mineral = minerals[i];
        mineralValue += GetMineralValue(mineral);
        count++;
        
        if(count == 5){
            mineralValues.push_back(mineralValue);
            mineralValue = 0;
            count = 0;
        }
    }
    
    if(mineralValue > 0)
        mineralValues.push_back(mineralValue);
    
    // 크기 조정
    if(mineralValues.size() > pickCount)
        mineralValues.resize(pickCount);
    
    sort(mineralValues.begin(), mineralValues.end(), compare);
    
    // 피로도 계산
    for(int i = 0; i < mineralValues.size(); i++){
        int value = mineralValues[i];
        int fatigue = 0;
        string pick = "";
        
        if(picks[0] > 0) pick = "diamond";
        else if(picks[1] > 0) pick = "iron";
        else pick = "stone";
        
        if(pick == "diamond") picks[0]--;
        else if(pick == "iron") picks[1]--;
        else if(pick == "stone") picks[2]--;
        else break;
        
        fatigue = GetValueToFatigue(pick, value);
        printf("%i \n", fatigue);
        answer += fatigue;
    }
    
    return answer;
}
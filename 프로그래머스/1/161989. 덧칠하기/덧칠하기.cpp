#include <string>
#include <vector>

using namespace std;

int solution(int n, int m, vector<int> section) {
    int answer = 1;
    int end = section[0] + m;
    
    for(int i = 0; i < section.size(); i++){
        int currentSection = section[i];
        if(currentSection >= end){
            end = currentSection + m;
            answer++;
        }
    }
    
    return answer;
}
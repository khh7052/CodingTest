#include <string>
#include <vector>

using namespace std;

int solution(string t, string p) {
    int answer = 0;
    unsigned long long pNum = stoull(p);
    
    for(int i = 0; i <= t.length() - p.length(); i++){
        string s = t.substr(i, p.length());
        long long tNum = stoll(s);
        if(tNum <= pNum)
            answer++;
    }
    
    return answer;
}
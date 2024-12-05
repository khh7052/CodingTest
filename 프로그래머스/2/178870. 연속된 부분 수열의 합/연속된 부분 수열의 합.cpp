#include <string>
#include <vector>
#include<algorithm>

using namespace std;

vector<int> solution(vector<int> sequence, int k) {
    
    vector<int> answer;
    
    int sum = sequence[0];
    int s = 0, e = 0;
    int minLength = 100000000;
    
    while(s <= e && e < sequence.size()){
        if(sum < k){
            sum += sequence[++e];
        }
        else if(sum == k){
            int length = e - s;
            if(minLength > length){
                minLength = length;
                answer = {s, e};
            }
            
            sum -= sequence[s++];
        }
        else{
            sum -= sequence[s++];
        }
        
    }
    
    
    return answer;
}
#include <string>
#include <vector>

using namespace std;

int dfs(int i, vector<int> numbers, int end, int sum, int target);

int solution(vector<int> numbers, int target) {
    int answer = 0;
    
    answer = dfs(0, numbers, numbers.size(), 0, target);
    
    return answer;
}

int dfs(int i, vector<int> numbers, int end, int sum, int target){
    
    if(i >= end){
        if(sum == target) return 1;
        else return 0;
    }
    else{
        return dfs(i+1, numbers, end, sum + numbers[i], target) + dfs(i+1, numbers, end, sum - numbers[i], target);
    }
}

#include <string>
#include <vector>

using namespace std;

int dfs(int i, vector<int> numbers, int sum, int target);

int solution(vector<int> numbers, int target) {
    int answer = 0;
    
    answer = dfs(0, numbers, 0, target);
    
    return answer;
}

int dfs(int i, vector<int> numbers, int sum, int target){
    
    if(i >= numbers.size()){
        if(sum == target) return 1;
        else return 0;
    }
    else{
        return dfs(i+1, numbers, sum + numbers[i], target) + dfs(i+1, numbers, sum - numbers[i], target);
    }
}

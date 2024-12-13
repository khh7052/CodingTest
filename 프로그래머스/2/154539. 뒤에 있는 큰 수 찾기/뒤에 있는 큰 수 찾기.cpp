#include <string>
#include <vector>
#include <stack>

using namespace std;

vector<int> solution(vector<int> numbers) {
    vector<int> answer(numbers.size(), -1);
    stack<int> stack;
    
    for(int i = 0; i < numbers.size(); i++){
        while(!stack.empty() && numbers[stack.top()] < numbers[i]) {
            answer[stack.top()] = numbers[i];
            
            stack.pop();
        }
        stack.push(i);
    }
    
    return answer;
}
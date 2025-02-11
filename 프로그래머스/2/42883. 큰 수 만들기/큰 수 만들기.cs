using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string number, int k) {
        
        // 1. 숫자의 맨 앞부터 뒤까지 순회
        // 2. 앞의 각 1의 자리의 모든 숫자가 자신보다 작고, k개 이하로 존재하면 앞의 숫자를 지운다.
        string answer = "";
        Queue<char> charQueue = new Queue<char>(number.ToCharArray());
        Stack<char> answerStack = new Stack<char>();
        
        while(charQueue.Count > 0 && k > 0){
            char c = charQueue.Dequeue();
            
            if(answerStack.Count == 0){
                answerStack.Push(c);
                continue;
            }
            
            while(answerStack.Peek() < c){
                answerStack.Pop();
                if(--k == 0) break;
                if(answerStack.Count == 0) break;
            }
            
            answerStack.Push(c);
        }
        
        while(charQueue.Count > 0)
            answerStack.Push(charQueue.Dequeue());
        
        while(k > 0){
            answerStack.Pop();
            k--;
        }
        
        var stackArr = answerStack.ToArray();
        Array.Reverse(stackArr);
        answer = new string(stackArr);
        
        return answer;
    }
}


/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution {
    public string solution(string number, int k) {
        HashSet<string> visited = new HashSet<string>();
        HashSet<string> numSet = new HashSet<string>();
        Queue<string> queue = new Queue<string>();
        
        queue.Enqueue(number);
        
        while(queue.Count > 0){
            string num = queue.Dequeue();
            
            // 이전에 중복된 문자열이 있으면 중지
            if(visited.Contains(num)) continue;
            visited.Add(num);
            
            // k개수만큼 뺏으면 중지
            if(num.Length == number.Length - k){
                numSet.Add(num);
                continue;
            }
            StringBuilder sb = new StringBuilder(num);
            // 문자열의 각 부분을 뺀 것을 큐에 추가
            for(int i = 0; i < num.Length; i++){
                sb.Remove(i, 1);
                queue.Enqueue(sb.ToString());
                sb.Insert(i, num[i]);
            }
        }
        
        return numSet.Max();
    }
}
*/
using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] order) {
        int answer = 0;

        Stack<int> main = new Stack<int>();
        Stack<int> sub = new Stack<int>();

        for (int i = order.Length; i >= 1; i--)
            main.Push(i);

        for (int i = 0; i < order.Length; i++) {
            int target = order[i];
            
            // 서브에서 꺼낼 수 있는 경우
            if (sub.Count > 0 && sub.Peek() == target) {
                sub.Pop();
                answer++;
                continue;
            }
            
            // 메인에서 target이 나올 때까지 서브로 이동
            while (main.Count > 0 && main.Peek() != target)
                sub.Push(main.Pop());

            // 메인에서 바로 꺼낼 수 있는 경우
            if (main.Count > 0 && main.Peek() == target) {
                main.Pop();
                answer++;
            }
            // 서브, 메인에서 없으면 종료
            else break;
        }

        return answer;
    }
}

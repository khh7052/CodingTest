using System;
using System.Text;

public class Solution {
    public int solution(string name) {
        int answer = 0;
        int length = name.Length;
        int move = length - 1; // 최적의 이동 거리
        
        // 각 자리에서 알파벳 변경하는 최소 횟수 구하기
        for (int i = 0; i < length; i++) {
            char c = name[i];
            answer += Math.Min(c - 'A', 'Z' - c + 1);

            // 다음 'A'가 아닌 위치 탐색
            int next = i + 1;
            while (next < length && name[next] == 'A') next++;

            // 이동 거리 최적화
            move = Math.Min(move, (i * 2) + (length - next));
            move = Math.Min(move, (length - next) * 2 + i);
        }

        return answer + move;
    }
}


/*
using System;
using System.Text;

public class Solution {
    public int solution(string name) {
        int answer = 0;
        string target = "";
        
        for(int i = 0; i < name.Length; i++)
            target += "A";
        
        int idx = 0;
        StringBuilder sb = new StringBuilder(name);
        
        while(sb.ToString() != target){
            // 알파벳 설정
            if(sb[idx] != 'A'){
                // A로 가는 최단거리 확인
                int leftDist = sb[idx] - 'A';
                int rightDist = 'Z' - sb[idx]+1;
                int min = Math.Min(leftDist, rightDist);
                
                Console.Write($"Change {sb[idx]} -> A  Move {min}  ");
                answer += min;
                sb[idx] = 'A';
                Console.WriteLine($"{sb}");
            }
            
            // 끝나면 종료
            if(sb.ToString() == target) return answer;
            
            // A가 아닌 가장 가까운 알파벳 위치 확인
            // 우측 거리 확인
            int tempIdx = idx;
            for(int i = 1; i <= name.Length; i++){
                int rightIdx = (idx+i)% name.Length;
                int leftIdx = (idx-i)% name.Length < 0? (idx-i)% name.Length + name.Length: (idx-i)% name.Length;
                if(sb[rightIdx] != 'A'){
                    Console.WriteLine($"Right Move {idx} -> {rightIdx}  Add {i}");
                    idx = rightIdx;
                    answer += i;
                    break;
                }
                else if(sb[leftIdx] != 'A'){
                    Console.WriteLine($"Left Move {idx} {leftIdx}  Add {i}");
                    idx = leftIdx;
                    answer += i;
                    break;
                }
            }
        }
        
        return answer;
    }
}
*/
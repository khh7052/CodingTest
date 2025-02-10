using System;
using System.Collections.Generic;

public class Solution {
    
    public bool IsPrime(int num){
        if(num < 2) return false;
        if(num == 2) return true;
        if(num % 2 == 0) return false;
        for(int i = 3; i * i <= num; i += 2)
            if(num % i == 0) return false;
        
        return true;
    }
    
    int FindPrime(List<int> stack, int[] arr, int targetLength, HashSet<int> checkedNumbers){
        if(stack.Count == targetLength){
            int num = 0;
            for (int i = 0; i < stack.Count; i++)
                num = num * 10 + stack[i]; // 숫자 조합
            
            if (checkedNumbers.Contains(num)) return 0; // 중복 방지
            checkedNumbers.Add(num);
            
            return IsPrime(num) ? 1 : 0;
        }
        
        int sum = 0;
        
        for(int i = 0; i < arr.Length; i++){
            if(arr[i] == -1) continue; // 이미 사용한 숫자 체크
            int temp = arr[i];
            stack.Add(arr[i]);
            arr[i] = -1; // 사용 표시
            
            sum += FindPrime(stack, arr, targetLength, checkedNumbers);
            
            stack.RemoveAt(stack.Count - 1);
            arr[i] = temp; // 원래 값 복구
        }
        
        return sum;
    }
    
    public int solution(string numbers) {
        int answer = 0;
        int[] numArr = new int[numbers.Length];
        List<int> stack = new List<int>();
        HashSet<int> checkedNumbers = new HashSet<int>(); // 중복 체크용
        
        for(int i = 0; i < numbers.Length; i++)
            numArr[i] = numbers[i] - '0';
        
        for(int i = 1; i <= numbers.Length; i++){
            answer += FindPrime(stack, numArr, i, checkedNumbers);
        }
        
        return answer;
    }
}

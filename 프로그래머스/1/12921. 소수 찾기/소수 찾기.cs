using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        bool[] isPrime = new bool[n+1];
        Array.Fill(isPrime, true);
        
        isPrime[0] = false;
        isPrime[1] = false;
        
        for (int i = 2; i * i <= n; i++)
            if (isPrime[i])
                for (int j = i * i; j <= n; j += i)
                    isPrime[j] = false;

        for(int i = 2; i <= n; i++)
            if(isPrime[i]) answer++;
        
        return answer;
    }
}
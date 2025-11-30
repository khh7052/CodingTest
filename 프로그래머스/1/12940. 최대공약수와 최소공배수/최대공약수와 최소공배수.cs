using System;

public class Solution {
    public int[] solution(int n, int m)
        => new int[] { GCD(n, m), LCM(n, m) };
    
    public int GCD(int a, int b){
        if(a % b == 0) return b;
        return GCD(b, a % b);
    }
    
    public int LCM(int a, int b)
        => a * b / GCD(a, b);
}
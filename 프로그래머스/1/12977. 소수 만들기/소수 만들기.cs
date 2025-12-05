using System;
using System.Linq;
using System.Collections.Generic;

class Solution
{
    public int solution(int[] nums)
    {
        List<int> sumList = new List<int>();
        int max = -1;
        
        for(int i = 0; i < nums.Length; i++){
            for(int j = i+1; j < nums.Length; j++){
                for(int k = j+1; k < nums.Length; k++){
                    int sum = nums[i] + nums[j] + nums[k];
                    max = Math.Max(max, sum);
                    sumList.Add(sum);
                }
            }
        }
        
        bool[] isPrime = new bool[max + 1];
        
        for(int i = 0; i < isPrime.Length; i++)
            isPrime[i] = true;
        
        for(int i = 2; i*i < isPrime.Length; i++)
        {
            if(!isPrime[i]) continue;
            for(int j = i*i; j <= max; j += i)
                isPrime[j] = false;
        }
        
        return sumList.Count(x => isPrime[x]);
    }
}
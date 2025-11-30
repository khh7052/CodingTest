using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] numbers) {
        HashSet<int> collections = new HashSet<int>();
        
        for(int i = 0; i < numbers.Length; i++)
            for(int j = i + 1; j < numbers.Length; j++)
                collections.Add(numbers[i] + numbers[j]);
        
        return collections.OrderBy(x => x).ToArray();
    }
}
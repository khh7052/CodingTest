using System;
using System.Linq;

public class Solution {
    public string solution(int[] numbers) {
        var arr = numbers.Select(n => n.ToString()).ToArray();

        Array.Sort(arr, (a, b) => (b + a).CompareTo(a + b));

        string answer = string.Concat(arr);

        if (answer[0] == '0')
            return "0";
        
        return answer;
    }
}
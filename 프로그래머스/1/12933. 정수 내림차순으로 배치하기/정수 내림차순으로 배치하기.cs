using System;
using System.Linq;

public class Solution {
    public long solution(long n) {
        string sorted = new string(n.ToString().OrderByDescending(x => x).ToArray());
        return long.Parse(sorted);
    }
}
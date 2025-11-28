using System;
using System.Linq;

public class Solution {
    public string solution(string s)
        => string.Concat(s.ToCharArray().OrderByDescending((x)=>x));
}
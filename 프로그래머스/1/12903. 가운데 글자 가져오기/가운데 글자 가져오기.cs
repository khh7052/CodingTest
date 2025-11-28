public class Solution {
    public string solution(string s) {
        int n = s.Length;
        return n % 2 == 0 ? $"{s[n/2-1]}{s[n/2]}" : s[n/2].ToString();
    }
}
public class Solution {
    public bool solution(string s) 
        => int.TryParse(s, out int num) && (s.Length == 4 || s.Length == 6);
}
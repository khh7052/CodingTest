using System.Linq;

public class Solution {
    public string solution(string s, int n) 
        => new string(s.Select(c => Push(c, n)).ToArray());
    
    char Push(char c, int n){
        if (c == ' ') return ' ';

        if (char.IsUpper(c)) 
            return (char)((c - 'A' + n) % 26 + 'A');

        return (char)((c - 'a' + n) % 26 + 'a');
    }
}

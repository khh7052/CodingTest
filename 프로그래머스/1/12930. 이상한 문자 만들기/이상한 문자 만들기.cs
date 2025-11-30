using System.Linq;

public class Solution {
    public string solution(string s){
        string answer = "";
        string[] split = s.Split();
        for(int i = 0; i < split.Length; i++)
            split[i] = new string(split[i].Select((c, index) => index % 2 == 0 ? char.ToUpper(c) : char.ToLower(c)).ToArray());
        return string.Join(" ", split);
    }
}
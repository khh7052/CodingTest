using System.Linq;

public class Solution {
    public string[] solution(string[] strings, int n)
        => strings.OrderBy(x => x[n]).ThenBy(x => x).ToArray();
}
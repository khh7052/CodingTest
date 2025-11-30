using System.Text;

public class Solution {
    public string solution(int[] food) {
        StringBuilder sb = new StringBuilder();
        
        for(int i = 1; i < food.Length; i++)
            sb.Append((char)('0' + i), food[i] / 2);
        
        sb.Append('0');
        
        for(int i = food.Length-1; i > 0; i--)
            sb.Append((char)('0' + i), food[i] / 2);
        
        return sb.ToString();
    }
}
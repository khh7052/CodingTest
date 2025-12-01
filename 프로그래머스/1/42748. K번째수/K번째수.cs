using System.Linq;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        int n = commands.GetLength(0);
        int[] answer = new int[n];
        
        for(int i = 0; i < n; i++){
            int skip = commands[i, 0] - 1;
            int take = commands[i, 1] - skip;
            int selectIndex = commands[i, 2] - 1;
            
            answer[i] = array
                .Skip(skip)
                .Take(take)
                .OrderBy(x => x)
                .ElementAt(selectIndex);
        }
        
        return answer;
    }
}
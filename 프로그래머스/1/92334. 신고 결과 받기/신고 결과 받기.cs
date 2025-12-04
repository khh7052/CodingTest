using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(string[] id_list, string[] report, int k) {
        int[] answer = new int[id_list.Length];
        Dictionary<string, int> idIndexMap = new Dictionary<string, int>();
        Dictionary<string, HashSet<string>> reportDict = new Dictionary<string, HashSet<string>>();  // 자신을 신고한 사람들 모음
        
        for(int i = 0; i < id_list.Length; i++){
            idIndexMap.Add(id_list[i], i);
            reportDict.Add(id_list[i], new HashSet<string>());
        }
        
        foreach(string str in report){
            string[] split = str.Split();
            string id = split[0];
            string reportId = split[1];
            reportDict[reportId].Add(id);
        }
        
        foreach(var v in reportDict){
            if(v.Value.Count < k) continue;
            
            foreach(var reporter in v.Value){
                int idx = idIndexMap[reporter];
                answer[idx]++;
            }
        }
        
        return answer;
    }
}
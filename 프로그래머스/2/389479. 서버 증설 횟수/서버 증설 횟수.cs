using System;

public class Solution {
    public int solution(int[] players, int m, int k) {
        int answer = 0;
        int server = 0;
        int[] returnTime = new int[players.Length];
        
        
        for(int i = 0; i < players.Length; i++){
            server -= returnTime[i]; // 서버 반환
            int needServer = players[i] / m; // 유저수에 따라 필요한 서버
            
            // 서버 증설
            if(needServer > server){
                int invertal = needServer - server;
                if(i + k < returnTime.Length)
                    returnTime[i+k] += invertal;
                
                answer += invertal;
                server += invertal;
            }
        }
        
        return answer;
    }
}
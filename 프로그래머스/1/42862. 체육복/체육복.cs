using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
        for(int i = 0; i < lost.Length; i++){
            for(int j = 0; j < reserve.Length; j++){
                if(lost[i] == reserve[j]){
                    lost[i] = 0;
                    reserve[j] = 0;
                }
            }
        }
        
        Array.Sort(lost);
        Array.Sort(reserve);
        
        Queue<int> lostQ = new Queue<int>(lost);
        Queue<int> reserveQ = new Queue<int>(reserve);
        int lostCount = 0;
        
        while(lostQ.Count > 0 && reserveQ.Count > 0){
            int lostNum = lostQ.Peek();
            int reserveNum = reserveQ.Peek();
            //Console.WriteLine($"Lost {lostNum} Reserve {reserveNum}");
            if(lostNum + 1 < reserveNum){
                lostCount++;
                lostQ.Dequeue();
            }
            else if(lostNum > reserveNum + 1){
                reserveQ.Dequeue();
            }
            else{
                reserveQ.Dequeue();
                lostQ.Dequeue();
            }
        }
        
        lostCount += lostQ.Count;
        //Console.WriteLine($"Lost {lostCount}");
        
        return n - lostCount;
    }
}
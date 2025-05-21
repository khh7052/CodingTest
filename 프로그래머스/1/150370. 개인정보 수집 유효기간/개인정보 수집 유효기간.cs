using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string today, string[] terms, string[] privacies) {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        List<int> list = new List<int>();
        
        int todayNum = DateToDay(today);
        
        for(int i = 0; i < terms.Length; i++){
            string[] split = terms[i].Split();
            dict[split[0]] = int.Parse(split[1]) * 28;
        }
        
        for(int i = 0; i < privacies.Length; i++){
            string[] split = privacies[i].Split();
            string date = split[0];
            string term = split[1];
            
            int privacyNum = DateToDay(date);
            int termNum = dict[term];
                
            Console.WriteLine(todayNum - privacyNum + " " + termNum);
            if(todayNum - privacyNum >= termNum)
                list.Add(i+1);
        }
        
        return list.ToArray();
    }
    
    public int DateToDay(string date){
        string[] split = date.Split('.');
        int year = int.Parse(split[0]);
        int month = int.Parse(split[1]);
        int day = int.Parse(split[2]);
        
        year -= 2000;
        month += year * 12;
        day += month * 28;
        
        return day;
    }
}
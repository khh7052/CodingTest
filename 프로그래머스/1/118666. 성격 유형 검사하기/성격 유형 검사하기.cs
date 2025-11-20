using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string[] survey, int[] choices) {
        string answer = "";
        Dictionary<char, int> scoreDict = new Dictionary<char, int>() {
            { 'R', 0 },
            { 'T', 0 },
            
            { 'C', 0 },
            { 'F', 0 },
            
            { 'J', 0 },
            { 'M', 0 },
            
            { 'A', 0 },
            { 'N', 0 },
        };
        int[] score = { 0, 3, 2, 1, 0, 1, 2, 3 };
        
        for(int i = 0; i < survey.Length; i++){
            int choice = choices[i];
            char key = choice <= 4? survey[i][0] : survey[i][1];
            
            scoreDict[key] += score[choice];
        }
        
        answer += scoreDict['R'] >= scoreDict['T'] ? 'R' : 'T';
        answer += scoreDict['C'] >= scoreDict['F'] ? 'C' : 'F';
        answer += scoreDict['J'] >= scoreDict['M'] ? 'J' : 'M';
        answer += scoreDict['A'] >= scoreDict['N'] ? 'A' : 'N';
        
        return answer;
    }
}
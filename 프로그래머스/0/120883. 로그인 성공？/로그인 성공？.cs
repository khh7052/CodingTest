using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string[] id_pw, string[,] db) {
        Dictionary<string, string> database = new Dictionary<string, string>();
        
        for(int i = 0; i < db.GetLength(0); i++){
            string id = db[i, 0];
            string pw = db[i, 1];
            database[id] = pw;
        }
        
        string userId = id_pw[0];
        string userPw = id_pw[1];
        
        if(!database.ContainsKey(userId)) return "fail";
        else return database[userId] == userPw ? "login" : "wrong pw";
    }
}
using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] players, string[] callings) {
        Dictionary<string, int> dic = new Dictionary<string, int>();
        string[] answer = new string[players.Length];
        
        for(int i=0; i<players.Length; i++)
        {
            dic.Add(players[i], i);
        }
        
        for(int j=0; j<callings.Length; j++)
        {
            int temp = dic[callings[j]];
            string fore = players[temp-1];
            
            dic[callings[j]] = dic[fore];
            dic[fore] = temp;
            
            players[temp-1] = callings[j];
            players[temp] = fore;
        }
        
        foreach(var i in dic)
        {
            answer[i.Value] = i.Key;
        }

        return answer;
    }
}
using System;

public class Solution {
    public int[] solution(string s) {
        int[] idx = new int['z'-'a'+1];
        Array.Fill(idx, -1);
        int[] answer = new int[] {};
        Array.Resize(ref answer, s.Length);
        
        for(int i=0; i<s.Length; i++)
        {
            if(idx[s[i] - 'a'] == -1)
            {
                idx[s[i] - 'a'] = i;
                answer[i] = -1;
            }
            else
            {
                answer[i] = i - idx[s[i] - 'a'];
                idx[s[i] - 'a'] = i;
            }
        }
        
        return answer;
    }
}
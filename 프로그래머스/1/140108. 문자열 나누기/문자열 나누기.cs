using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        int cnt = 0;
        int ont = 0;
        char c = ' ';
        
        for(int i=0; i<s.Length; i++)
        {
            if(cnt == 0)
            {
                cnt = 1;
                c = s[i];
                continue;
            }
            if(s[i] == c)
            {
                cnt++;
            }
            else
            {
                ont++;
                if(ont == cnt)
                {
                    answer++;
                    cnt = 0;
                    ont = 0;
                }
            }
        }
        if(cnt != 0)
            answer++;
        
        return answer;
    }
}
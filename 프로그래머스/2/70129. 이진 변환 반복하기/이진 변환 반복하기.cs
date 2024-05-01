using System;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[2];
        
        while(!s.Equals("1"))
        {
            int ocnt = 0;
            int zcnt = 0;
            for(int i=0; i<s.Length; i++)
            {
                if(s[i] == '0')
                    zcnt++;
                else
                    ocnt++;
            }
            
            s = Convert.ToString(ocnt, 2);
            
            answer[0]++;
            answer[1] += zcnt;
        }
        return answer;
    }
}
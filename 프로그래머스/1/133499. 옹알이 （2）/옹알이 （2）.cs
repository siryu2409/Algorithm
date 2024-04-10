using System;

public class Solution {
    
    public string[] bab = {"aya", "ye", "woo", "ma"};
    
    public int solution(string[] babbling) {
        int answer = 0;
        int idx = 0;
        int curstr = -1;
        
        for(int i=0; i<babbling.Length; i++)
        {
            while(idx < babbling[i].Length)
            {
                int curmat = -1;
                for(int j=0; j<bab.Length; j++)
                {
                    if(idx + bab[j].Length > babbling[i].Length)
                        continue;

                    if(babbling[i].Substring(idx, bab[j].Length).CompareTo(bab[j]) == 0)
                    {
                        curmat = j;
                        if(curstr == curmat)
                        {
                            curmat = -1;
                            break;
                        }
                        curstr = j;
                        idx += bab[j].Length;
                    }
                }
                
                if(curmat == -1)
                {
                    break;
                } 
            }
            if(idx == babbling[i].Length)
            {
                answer++;
            }
            curstr = -1;
            idx = 0;
        }
        
        return answer;
    }
}
using System;

public class Solution {
    public int[] solution(string[] keymap, string[] targets) {
        int[] cnt = new int['Z'-'A'+1];
        
        for(int i=0; i<cnt.Length; i++)
        {
            cnt[i] = 101;
        }
        
        for(int i=0; i<cnt.Length; i++)
        {
            foreach(string s in keymap)
            {
                for(int j=0; j<s.Length; j++)
                {
                    if(j + 1 < cnt[s[j] - 'A'])
                    {
                        cnt[s[j] - 'A'] = j + 1;
                    }
                }
            }
        }
        
        int[] answer = new int[targets.Length];
        
        for(int i=0; i<targets.Length; i++)
        {
            for(int j=0; j<targets[i].Length; j++)
            {
                if(cnt[targets[i][j] - 'A'] == 101)
                {
                    answer[i] = -1;
                    break;
                }
                answer[i] += cnt[targets[i][j] - 'A'];
            }
        }
        
        return answer;
    }
}
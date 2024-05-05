using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Solution {
    public int solution(int k, int[] tangerine) {
        List<int> mp = new List<int>();
        Array.Sort(tangerine);
        int answer = 0;
        int current = tangerine[0];
        int curidx = 0;
        mp.Add(1);
        for(int i=1; i<tangerine.Length; i++)
        {
            if(tangerine[i] == current)
            {
                mp[curidx]++;
            }
            else
            {
                current = tangerine[i];
                curidx++;
                mp.Add(1);
            }
        }
        
        mp.Sort((a, b) => -a.CompareTo(b));
        
        int total = 0;
        for(int i=0; i<mp.Count; i++)
        {
            total += mp[i];
            answer++;
            if(total >= k)
                break;
        }
        return answer;
    }
}
using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
        int answer = 0;
        IEnumerable<int> dups = from dup in lost.Intersect(reserve) select dup;
        Array.Sort(lost);
        Array.Sort(reserve);
        
        int[] rlost = (from lst in lost.Except(dups) select lst).ToArray();
        int[] rresv = (from resv in reserve.Except(dups) select resv).ToArray();
        
        for(int i=0; i<rlost.Length; i++)
        {
            for(int j=0; j<rresv.Length; j++)
            {
                if(rresv[j] == 0) continue;
                // left
                if(rlost[i]-1 == rresv[j])
                {
                    rlost[i] = 0;
                    rresv[j] = 0;
                    break;
                }
                // right
                else if(rlost[i]+1 == rresv[j])
                {
                    rlost[i] = 0;
                    rresv[j] = 0;
                    break;
                }
            }
        }
        
        for(int i=0; i<rlost.Length; i++)
        {
            if(rlost[i] != 0) answer++;
        }
        
        return n - answer;
    }
}
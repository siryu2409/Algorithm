using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] answers) {
        int[] fir = new int[] {1,2,3,4,5};
        int[] sec = new int[] {2,1,2,3,2,4,2,5};
        int[] thr = new int[] {3,3,1,1,2,2,4,4,5,5};
        int[] ar = new int[] {0,0,0};
        List<int> ans = new List<int>();
        
        for(int i=0; i<answers.Length; i++)
        {
            if(answers[i] == fir[i % fir.Length])
                ar[0]++;
            if(answers[i] == sec[i % sec.Length])
                ar[1]++;
            if(answers[i] == thr[i % thr.Length])
                ar[2]++;
        }
        
        int big = ar[0];
        if(big < ar[1])
            big = ar[1];
        if(big < ar[2])
            big = ar[2];
        
        for(int i=0; i<ar.Length; i++)
        {
            if(ar[i] >= big)
                ans.Add(i+1);
        }
        
        return ans.ToArray();
    }
}
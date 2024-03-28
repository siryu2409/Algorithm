using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int k, int[] score) {
        int[] answer = new int[score.Length];
        List<int> hof = new List<int>();
        int sml = int.MaxValue;
        
        for(int i=0; i<score.Length; i++)
        {
            hof.Add(score[i]);
            hof.Sort();
            if(hof.Count > k)
                hof.RemoveAt(0);
            
            answer[i] = hof[0];
        }
        return answer;
    }
}
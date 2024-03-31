using System;
using System.Collections;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
        int idx1 = 0;
        int idx2 = 0;
        
        for(int i=0; i<goal.Length; i++)
        {
            if(idx1 < cards1.Length && (String.Compare(cards1[idx1], goal[i]) == 0)) 
            {
                idx1++;
            }
            else if(idx2 < cards2.Length && (String.Compare(cards2[idx2], goal[i]) == 0)) 
            {
                idx2++;      
            }
            else return "No";
        }
        return "Yes";
    }
}
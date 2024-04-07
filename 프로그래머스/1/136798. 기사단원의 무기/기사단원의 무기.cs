using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int number, int limit, int power) {
        int[] divs = new int[number+1];
        int answer = 0;
        
        for(int i=1; i<divs.Length; i++)
        {
            for(int j=i; j<divs.Length; j = j+i)
            {
                divs[j]++;
            }
            answer += (divs[i] > limit) ? power : divs[i];
        }
        
        return answer;
    }
}
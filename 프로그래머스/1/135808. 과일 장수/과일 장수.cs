using System;

public class Solution {
    public int solution(int k, int m, int[] score) {
        int answer = 0;
        Array.Sort(score);
        int idx = score.Length % m;
        while(idx < score.Length)
        {
            answer += m * score[idx];
            idx += m;
        }
        return answer;
    }
}
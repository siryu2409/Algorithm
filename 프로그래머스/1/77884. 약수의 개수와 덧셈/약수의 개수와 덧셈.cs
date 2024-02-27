using System;

public class Solution {
    public int solution(int left, int right) {
        int answer = 0;
        for(int i=left; i<right+1; i++)
        {
            answer += GetNumberOfMeasure(i) % 2 == 0 ? i : -i;
        }
        return answer;
    }
    
    int GetNumberOfMeasure(int n)
    {
        if(n == 1) return 1;
        int num = 2;
        for(int i = 2; i < n; i++)
        {
            if(n % i == 0)
                num++;
        }
        return num;
    }
}
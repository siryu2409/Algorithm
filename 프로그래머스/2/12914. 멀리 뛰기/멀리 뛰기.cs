using System.Collections.Generic;

public class Solution {
    public long solution(int n) {
        int[] fibo = new int[n+1];
        fibo[1] = 1;
        if(n > 1)
            fibo[2] = 2;
        for(int i=3; i<n+1; i++)
        {
            fibo[i] = (fibo[i-1] + fibo[i-2]) % 1234567;
        }
        return fibo[n];
    }
}
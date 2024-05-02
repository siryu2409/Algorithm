using System.Collections.Generic;
using System;

public class Solution {
    
    public List<int> fibos = new List<int>();
    
    public int solution(int n) {
        fibos.Add(0);
        fibos.Add(1);
        fibo(2, n);
        int answer = fibos[n];
        return answer;
    }
    
    public void fibo(int a, int n)
    {
        if(a == n+1) return;
        int next = (fibos[a-1] + fibos[a-2]) % 1234567;
        fibos.Add(next);
        fibo(a+1, n);
    }
}
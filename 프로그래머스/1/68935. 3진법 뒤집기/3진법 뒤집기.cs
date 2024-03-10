using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        int pow = 1;
        
        if(n < 3)
            return n;
        
        while(pow <= n)
        {
            pow *= 3;
            Console.WriteLine(pow);
        }
        
        pow /= 3;
        
        while(n > 0)
        {
            answer += (n % 3) * pow;
            pow /= 3;
            n /= 3;
        }
        
        
        return answer;
    }
}
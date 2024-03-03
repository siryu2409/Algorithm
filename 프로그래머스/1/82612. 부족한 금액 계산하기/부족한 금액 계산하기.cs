using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        long ans = (long)(count * (count+1) / 2) * price;
        return ans > money ? ans - money : 0;
    }
}
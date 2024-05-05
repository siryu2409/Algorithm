using System;

public class Solution {
    public int solution(int[] arr) {
        int answer = 1;
        foreach(int i in arr)
        {
            if(answer % i == 0 || i % answer == 0)
            {
                answer = (answer > i) ? answer : i;
            }
            else 
            {
                int sml = (answer < i) ? answer : i;
                int ms = 1;
                for(int j=sml; j>0; j--)
                {
                    if(answer % j == 0 && i % j == 0)
                    {
                        ms = j;
                        break;
                    }
                }
                answer = answer * i / ms;
            }
        }
        return answer;
    }
}
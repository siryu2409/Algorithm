using System;
using System.Collections.Generic;

class Solution
{
    public int solution(int[] nums)
    {
        int answer = 0;
        
        bool[] primeArray = new bool[3001];
        
        Array.Fill(primeArray, true);
        
        for(int i=2; i<primeArray.Length; i++)
        {
            int idx = i * 2;
            while(idx < primeArray.Length)
            {
                primeArray[idx] = false;
                idx += i;
            }
        }
        
        for(int i=0; i<nums.Length-2; i++)
        {
            for(int j=i+1; j<nums.Length-1; j++)
            {
                for(int k=j+1; k<nums.Length; k++)
                {
                    if(primeArray[nums[i] + nums[j] + nums[k]])
                        answer++;
                }
            }
        }

        // [실행] 버튼을 누르면 출력 값을 볼 수 있습니다.
        System.Console.WriteLine("Hello C#");

        return answer;
    }
}
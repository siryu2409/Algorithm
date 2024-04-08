using System;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        int[] answer = new int[2] {0, 0};
        Array.Sort(lottos);
        Array.Sort(win_nums);
        
        int fit = 0;
        int zeros = 0;
        int idx = 0;
        for(int i=0; i<lottos.Length; i++)
        {
            if(lottos[i] == 0)
                zeros++;
        }
        
        for(int i=zeros; i<lottos.Length; i++)
        {
            for(int j=idx; j<win_nums.Length; j++)
            {
                if(lottos[i] == win_nums[j])
                {
                    fit++;
                    idx = j;
                    break;
                }
            }
        }
        
        answer[0] = (7 - (fit + zeros)) < 6 ? (7 - (fit + zeros)) : 6;
        answer[1] = (7 - fit) < 6 ? (7 - fit) : 6;
        
        return answer;
    }
}
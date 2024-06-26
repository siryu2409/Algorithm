using System;

public class Solution {
    public int[] solution(int brown, int yellow) {
        int[] answer = new int[2];
        
        for(int i=1; i<=yellow; i++)
        {
            if(yellow % i == 0)
            {
                int j = yellow / i;
                Console.WriteLine($"{i}, {j}");
                if(((i+2) * (j+2)) == (brown + yellow))
                {
                    answer[1] = i+2;
                    answer[0] = j+2;
                    break;
                }
            }
        }
        
        return answer;
    }
}
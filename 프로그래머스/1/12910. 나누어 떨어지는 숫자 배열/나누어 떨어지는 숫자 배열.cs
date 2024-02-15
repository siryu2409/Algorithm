using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr, int divisor) {
        List<int> answer = new List<int>();
        foreach(int i in arr)
        {
            if(i % divisor == 0)
            {
                answer.Add(i);
            }
        }
        if(answer.Count == 0)
            answer.Add(-1);
        else
            answer = (from num in answer orderby num select num).ToList();
        return answer.ToArray();
    }
}
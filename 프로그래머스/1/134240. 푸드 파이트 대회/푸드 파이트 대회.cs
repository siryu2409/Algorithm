using System;
using System.Text;
using System.Collections.Generic;

public class Solution {
    public string solution(int[] food) {
        StringBuilder sb = new StringBuilder();
        Stack<int> stk = new Stack<int>();
        
        for(int i=1; i<food.Length; i++)
        {
            for(int j=0; j< (food[i]/2); j++)
            {
                sb.Append(i);
                stk.Push(i);
            }
        }
        sb.Append(0);
        while(stk.Count > 0)
        {
            sb.Append(stk.Pop());
        }
        return sb.ToString();
    }
}
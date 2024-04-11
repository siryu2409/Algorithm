using System;
using System.Text;

public class Solution {
    public string solution(string X, string Y) {
        StringBuilder sb = new StringBuilder();
        int[] arX = new int[10];
        int[] arY = new int[10];
        int ans = 0;
        
        for(int i=0; i<X.Length; i++)
        {
            arX[X[i] - '0']++;
        }
        
        for(int i=0; i<Y.Length; i++)
        {
            arY[Y[i] - '0']++;
        }
        
        for(int i=9; i>-1; i--)
        {
            int t = Math.Min(arX[i], arY[i]);
            if(t == 0) continue;
            for(int j=0; j<t; j++)
            {
                sb.Append(i);
            }
        }
        
        if(sb.ToString() == "") return "-1";
        if(sb.ToString()[0] == '0') return "0";
        
        return sb.ToString();
    }
}
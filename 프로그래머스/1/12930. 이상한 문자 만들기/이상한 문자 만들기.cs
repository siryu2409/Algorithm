using System;
using System.Text;

public class Solution {
    public string solution(string s) {
        StringBuilder sb = new StringBuilder();
        
        int idx = 0;
        
        for(int i=0; i<s.Length; i++)
        {
            if(s[i] == ' ')
            {
                sb.Append(' ');
                idx = 0;
            }
            else if(idx % 2 == 0)
            {
                sb.Append(Char.ToUpper(s[i]));
                idx++;
            }
            else 
            {
                sb.Append(Char.ToLower(s[i]));
                idx++;
            }
        }
        return sb.ToString();
    }
}
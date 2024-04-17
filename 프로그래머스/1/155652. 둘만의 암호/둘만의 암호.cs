using System;
using System.Text;

public class Solution {
    public const char alphabets = (char)('z'-'a'+1);
    
    public string solution(string s, string skip, int index) {
        StringBuilder sb = new StringBuilder();
        bool[] skipDic = new bool[alphabets];
        foreach(char c in skip)
        {
            skipDic[c-'a'] = true;
        }
        for(int i=0; i<s.Length; i++)
        {
            char c = s[i];
            int idx = index;
            while(idx > 0)
            {
                c = (char)(((++c-'a') % alphabets) + 'a');
                idx--;
                
                if(skipDic[c-'a']){
                    idx++;
                }
            }
            sb.Append(c);
        }
        return sb.ToString();
    }
}
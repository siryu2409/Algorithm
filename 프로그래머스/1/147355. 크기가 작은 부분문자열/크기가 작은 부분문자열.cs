using System;
using System.Text;

public class Solution {
    public int solution(string t, string p) {
        int answer = 0;
        StringBuilder sb = new StringBuilder();
        long pnum = long.Parse(p);
        for(int i=0; i <= t.Length - p.Length; i++)
        {
            sb.Append(t.Substring(i, p.Length));
            if(long.Parse(sb.ToString()) <= pnum)
                answer++;
            sb.Clear();
        }
        return answer;
    }
}
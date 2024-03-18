using System;
using System.Text;

public class Solution {
    
    string[] star = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
    
    public int solution(string s) {
        StringBuilder sb = new StringBuilder(s);
        for(int i=0; i<star.Length; i++)
        {
            sb.Replace(star[i], i.ToString());
        }
        int answer = int.Parse(sb.ToString());
        return answer;
    }
}
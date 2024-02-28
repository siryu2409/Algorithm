using System;
using System.Linq;

public class Solution {
    public string solution(string s) {
        string answer = new String(s.ToCharArray().OrderByDescending(c => c).ToArray());
        return answer;
    }
}
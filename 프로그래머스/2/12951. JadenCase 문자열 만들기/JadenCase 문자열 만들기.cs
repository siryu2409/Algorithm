public class Solution {
    
    public const int gap = 'A' - 'a';
    
    public string solution(string s) {
        char[] chars = new char[s.Length];
        bool isFirst = true;
        for(int i=0; i<s.Length; i++)
        {
            if(isFirst && s[i] != ' ')
            {
                if(s[i] >= 'a' && s[i] <= 'z')
                    chars[i] = (char)(s[i] + gap);
                else
                    chars[i] = s[i];
                isFirst = false;
            }
            else if(s[i] == ' ')
            {
                chars[i] = ' ';
                isFirst = true;
            }
            else if(s[i] >= 'A' && s[i] <= 'Z')
            {
                chars[i] = (char)(s[i] - gap);
            }
            else
            {
                chars[i] = s[i];
            }
        }
        
        string answer = new string(chars);
        return answer;
    }
}
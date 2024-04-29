public class Solution {
    public string solution(string s) {
        int min = int.MaxValue;
        int max = int.MinValue;
        string answer = "";
        string[] nums = s.Split(" ");
        foreach(string str in nums)
        {
            int val = int.Parse(str);
            if(val < min)
                min = val;
            if(val > max)
                max = val;
        }
        answer = $"{min} {max}";
        return answer;
    }
}
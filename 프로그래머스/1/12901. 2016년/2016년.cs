public class Solution {
    
    public static readonly string[] str = new string[] {"SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT"};
    public static readonly int[] ar = new int[12] {31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
    
    public string solution(int a, int b) {
        int days = 5;
        
        for(int i=0; i<(a-1); i++)
        {
            days += ar[i];
        }
        days += (b-1);
        return str[days % 7];
    }
}
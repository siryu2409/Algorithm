using System.Text;
using System;

public class Solution {
    public string solution(string phone_number) {
        int length = phone_number.Length;
        StringBuilder sb = new StringBuilder();
        sb.EnsureCapacity(length-4);
        sb.Append('*', length-4);
        sb.Append(phone_number.Substring(length-4));
        return sb.ToString();
    }
}
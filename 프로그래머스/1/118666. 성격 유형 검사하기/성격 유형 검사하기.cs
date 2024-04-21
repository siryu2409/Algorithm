using System;

public class Solution {
    public string solution(string[] survey, int[] choices) {
        int[] ar = new int['Z'-'A'+1];
        char[] ans = new char[4];
        
        for(int i=0; i<survey.Length; i++)
        {
            switch(choices[i])
            {
                case 1:
                    ar[survey[i][0] - 'A'] += 3;
                    break;
                case 2:
                    ar[survey[i][0] - 'A'] += 2;
                    break;
                case 3:
                    ar[survey[i][0] - 'A'] += 1;
                    break;
                case 4:
                    break;
                case 5:
                    ar[survey[i][1] - 'A'] += 1;
                    break;
                case 6:
                    ar[survey[i][1] - 'A'] += 2;
                    break;
                case 7:
                    ar[survey[i][1] - 'A'] += 3;
                    break;
            }
        }
        
        if(ar['R'-'A'] >= ar['T'-'A'])
            ans[0] = 'R';
        else ans[0] = 'T';
        
        if(ar['C'-'A'] >= ar['F'-'A'])
            ans[1] = 'C';
        else ans[1] = 'F';
        
        if(ar['J'-'A'] >= ar['M'-'A'])
            ans[2] = 'J';
        else ans[2] = 'M';
        
        if(ar['A'-'A'] >= ar['N'-'A'])
            ans[3] = 'A';
        else ans[3] = 'N';
        
        return new String(ans);
    }
}